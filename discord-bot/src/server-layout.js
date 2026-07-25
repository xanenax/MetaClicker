import {
  ActionRowBuilder,
  ButtonBuilder,
  ButtonStyle,
  ChannelType,
  EmbedBuilder,
  MessageType,
  PermissionFlagsBits,
} from "discord.js";

const ACCENT = 0x9235ff;
const MANAGED_REASON = "XANENAX MetaClicker automated setup";

const ROLE_DEFINITIONS = [
  {
    key: "creator",
    name: "XANENAX",
    color: 0x9235ff,
    hoist: true,
    permissions: [],
  },
  {
    key: "staff",
    name: "Staff",
    color: 0xc771ff,
    hoist: true,
    permissions: [
      PermissionFlagsBits.ManageMessages,
      PermissionFlagsBits.ModerateMembers,
      PermissionFlagsBits.KickMembers,
      PermissionFlagsBits.ViewAuditLog,
    ],
  },
  {
    key: "support",
    name: "Support",
    color: 0x5865f2,
    hoist: true,
    permissions: [PermissionFlagsBits.ManageMessages],
  },
  {
    key: "tester",
    name: "Tester",
    color: 0x57f287,
    hoist: false,
    permissions: [],
  },
  {
    key: "member",
    name: "Member",
    color: 0x99aab5,
    hoist: false,
    permissions: [],
  },
];

function readOnlyOverwrites(guild) {
  return [
    {
      id: guild.roles.everyone.id,
      deny: [PermissionFlagsBits.SendMessages],
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
    {
      id: guild.members.me.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.EmbedLinks,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
  ];
}

function staffOverwrites(guild, roles) {
  return [
    {
      id: guild.roles.everyone.id,
      deny: [PermissionFlagsBits.ViewChannel],
    },
    {
      id: roles.creator.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
    {
      id: roles.staff.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
    {
      id: roles.support.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
    {
      id: guild.members.me.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.EmbedLinks,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
  ];
}

function memberCategoryOverwrites(guild, roles) {
  const visibleTo = [
    roles.creator,
    roles.staff,
    roles.support,
    roles.tester,
    roles.member,
  ];

  return [
    {
      id: guild.roles.everyone.id,
      deny: [PermissionFlagsBits.ViewChannel],
    },
    ...visibleTo.map((role) => ({
      id: role.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    })),
    {
      id: guild.members.me.id,
      allow: [
        PermissionFlagsBits.ViewChannel,
        PermissionFlagsBits.SendMessages,
        PermissionFlagsBits.EmbedLinks,
        PermissionFlagsBits.ReadMessageHistory,
      ],
    },
  ];
}

function memberReadOnlyOverwrites(guild, roles) {
  return memberCategoryOverwrites(guild, roles).map((overwrite) => {
    if (overwrite.id === guild.roles.everyone.id) {
      return {
        ...overwrite,
        deny: [
          PermissionFlagsBits.ViewChannel,
          PermissionFlagsBits.SendMessages,
        ],
      };
    }

    if (overwrite.id === guild.members.me.id) {
      return overwrite;
    }

    return {
      ...overwrite,
      deny: [PermissionFlagsBits.SendMessages],
    };
  });
}

async function ensureRole(guild, definition) {
  let role = guild.roles.cache.find(
    (candidate) =>
      !candidate.managed && candidate.name === definition.name,
  );

  const roleData = {
    name: definition.name,
    colors: { primaryColor: definition.color },
    hoist: definition.hoist,
    mentionable: false,
    permissions: definition.permissions,
    reason: MANAGED_REASON,
  };

  if (!role) {
    role = await guild.roles.create(roleData);
  } else if (role.editable) {
    await role.edit(roleData);
  }

  return role;
}

async function ensureCategory(guild, name, permissionOverwrites = undefined) {
  let category = guild.channels.cache.find(
    (channel) =>
      channel.type === ChannelType.GuildCategory && channel.name === name,
  );

  if (!category) {
    category = await guild.channels.create({
      name,
      type: ChannelType.GuildCategory,
      permissionOverwrites,
      reason: MANAGED_REASON,
    });
  } else if (permissionOverwrites) {
    await category.permissionOverwrites.set(
      permissionOverwrites,
      MANAGED_REASON,
    );
  }

  return category;
}

async function ensureChannel(guild, category, definition) {
  let channel = guild.channels.cache.find(
    (candidate) =>
      candidate.name === definition.name &&
      candidate.type === definition.type,
  );

  if (!channel && definition.reuseDefaultNames?.length) {
    const reusableNames = definition.reuseDefaultNames.map((name) =>
      name.toLocaleLowerCase("en-US"),
    );

    channel = guild.channels.cache.find(
      (candidate) =>
        candidate.type === definition.type &&
        reusableNames.includes(candidate.name.toLocaleLowerCase("en-US")),
    );
  }

  const channelData = {
    name: definition.name,
    type: definition.type,
    parent: category.id,
    permissionOverwrites: definition.permissionOverwrites,
    reason: MANAGED_REASON,
  };

  if (definition.topic != null) {
    channelData.topic = definition.topic;
  }

  if (definition.rateLimitPerUser != null) {
    channelData.rateLimitPerUser = definition.rateLimitPerUser;
  }

  if (!channel) {
    channel = await guild.channels.create(channelData);
  } else if (channel.manageable) {
    await channel.edit(channelData);
  }

  return channel;
}

async function removeEmptyDefaultCategories(guild) {
  const defaultNames = new Set([
    "text channels",
    "textkanäle",
    "voice channels",
    "sprachkanäle",
  ]);

  await guild.channels.fetch();

  const emptyDefaultCategories = guild.channels.cache.filter(
    (channel) =>
      channel.type === ChannelType.GuildCategory &&
      defaultNames.has(channel.name.toLocaleLowerCase("de-DE")) &&
      channel.children.cache.size === 0 &&
      channel.deletable,
  );

  for (const category of emptyDefaultCategories.values()) {
    await category.delete(MANAGED_REASON);
  }
}

async function ensureSeedMessage(channel, marker, embed, components = []) {
  if (!channel?.isTextBased()) {
    return;
  }

  const recentMessages = await channel.messages.fetch({ limit: 20 });
  const alreadyExists = recentMessages.some((message) =>
    message.embeds.some((existingEmbed) =>
      existingEmbed.footer?.text?.includes(marker),
    ),
  );

  if (!alreadyExists) {
    await channel.send({ embeds: [embed], components });
  }
}

async function deleteLegacyJoinLog(guild) {
  const legacyChannel = guild.channels.cache.find(
    (channel) =>
      channel.type === ChannelType.GuildText &&
      channel.name === "join-log" &&
      channel.parent?.name === "STAFF",
  );

  if (legacyChannel?.deletable) {
    await legacyChannel.delete(MANAGED_REASON);
  }
}

async function removeNativeJoinMessages(channel) {
  if (!channel?.isTextBased()) {
    return;
  }

  const recentMessages = await channel.messages.fetch({ limit: 100 });
  const nativeJoinMessages = recentMessages.filter(
    (message) => message.type === MessageType.UserJoin && message.deletable,
  );

  for (const message of nativeJoinMessages.values()) {
    await message.delete();
  }
}

function baseEmbed(title, description, marker) {
  return new EmbedBuilder()
    .setColor(ACCENT)
    .setTitle(title)
    .setDescription(description)
    .setFooter({ text: `XANENAX Setup • ${marker}` });
}

export async function setupServer(guild, config) {
  await guild.roles.fetch();
  await guild.channels.fetch();

  const roles = {};
  for (const definition of ROLE_DEFINITIONS) {
    roles[definition.key] = await ensureRole(guild, definition);
  }

  const categories = {};
  const channels = {};

  categories.start = await ensureCategory(guild, "START HERE");
  channels.welcome = await ensureChannel(guild, categories.start, {
    name: "welcome",
    type: ChannelType.GuildText,
    topic: "New members, important links, and the fastest way to get started.",
    permissionOverwrites: readOnlyOverwrites(guild),
  });
  channels.rules = await ensureChannel(guild, categories.start, {
    name: "rules",
    type: ChannelType.GuildText,
    topic: "Short, clear community rules.",
    permissionOverwrites: readOnlyOverwrites(guild),
  });
  channels.verify = await ensureChannel(guild, categories.start, {
    name: "verify",
    type: ChannelType.GuildText,
    topic: "Verify once to unlock the MetaClicker community.",
    permissionOverwrites: readOnlyOverwrites(guild),
  });
  channels.joined = await ensureChannel(guild, categories.start, {
    name: "joined",
    type: ChannelType.GuildText,
    topic: "Custom welcome messages for new community members.",
    permissionOverwrites: readOnlyOverwrites(guild),
  });
  channels.announcements = await ensureChannel(guild, categories.start, {
    name: "announcements",
    type: ChannelType.GuildText,
    topic: "Important XANENAX and MetaClicker announcements.",
    permissionOverwrites: readOnlyOverwrites(guild),
  });

  const memberOnly = memberCategoryOverwrites(guild, roles);
  const memberReadOnly = memberReadOnlyOverwrites(guild, roles);

  categories.meta = await ensureCategory(
    guild,
    "META CLICKER",
    memberOnly,
  );
  channels.updates = await ensureChannel(guild, categories.meta, {
    name: "metaclicker-updates",
    type: ChannelType.GuildText,
    topic: "Release notes, fixes, and development updates.",
    permissionOverwrites: memberReadOnly,
  });
  channels.downloads = await ensureChannel(guild, categories.meta, {
    name: "downloads",
    type: ChannelType.GuildText,
    topic: "Official MetaClicker downloads only.",
    permissionOverwrites: memberReadOnly,
  });
  channels.support = await ensureChannel(guild, categories.meta, {
    name: "support",
    type: ChannelType.GuildText,
    topic: "Get help with installation, settings, or usage.",
    rateLimitPerUser: 5,
    permissionOverwrites: memberOnly,
  });
  channels.bugs = await ensureChannel(guild, categories.meta, {
    name: "bug-reports",
    type: ChannelType.GuildText,
    topic: "Report reproducible MetaClicker problems with screenshots and details.",
    rateLimitPerUser: 10,
    permissionOverwrites: memberOnly,
  });
  channels.suggestions = await ensureChannel(guild, categories.meta, {
    name: "suggestions",
    type: ChannelType.GuildText,
    topic: "Useful ideas for future MetaClicker updates.",
    rateLimitPerUser: 10,
    permissionOverwrites: memberOnly,
  });

  categories.xanenax = await ensureCategory(guild, "XANENAX", memberOnly);
  channels.youtube = await ensureChannel(guild, categories.xanenax, {
    name: "youtube",
    type: ChannelType.GuildText,
    topic: "New XANENAX videos and channel updates.",
    permissionOverwrites: memberReadOnly,
  });
  channels.videoIdeas = await ensureChannel(guild, categories.xanenax, {
    name: "video-ideas",
    type: ChannelType.GuildText,
    topic: "Suggest clients, tests, and video ideas.",
    rateLimitPerUser: 10,
    permissionOverwrites: memberOnly,
  });

  categories.community = await ensureCategory(
    guild,
    "COMMUNITY",
    memberOnly,
  );
  channels.general = await ensureChannel(guild, categories.community, {
    name: "general",
    type: ChannelType.GuildText,
    topic: "General XANENAX community chat.",
    reuseDefaultNames: ["Allgemein"],
    permissionOverwrites: memberOnly,
  });
  channels.media = await ensureChannel(guild, categories.community, {
    name: "media",
    type: ChannelType.GuildText,
    topic: "Share clips, screenshots, setups, and creations.",
    permissionOverwrites: memberOnly,
  });
  channels.wordle = await ensureChannel(guild, categories.community, {
    name: "wordle",
    type: ChannelType.GuildText,
    topic: "Play the daily Wordle with /wordle.",
    permissionOverwrites: memberOnly,
  });
  channels.botCommands = await ensureChannel(
    guild,
    categories.community,
    {
      name: "bot-commands",
      type: ChannelType.GuildText,
      topic: "Commands and future bot utilities.",
      permissionOverwrites: memberOnly,
    },
  );

  categories.voice = await ensureCategory(guild, "VOICE", memberOnly);
  channels.generalVoice = await ensureChannel(guild, categories.voice, {
    name: "General",
    type: ChannelType.GuildVoice,
    reuseDefaultNames: ["Allgemein"],
    permissionOverwrites: memberOnly,
  });
  channels.supportVoice = await ensureChannel(guild, categories.voice, {
    name: "Support",
    type: ChannelType.GuildVoice,
    permissionOverwrites: memberOnly,
  });

  categories.staff = await ensureCategory(
    guild,
    "STAFF",
    staffOverwrites(guild, roles),
  );
  channels.staffChat = await ensureChannel(guild, categories.staff, {
    name: "staff-chat",
    type: ChannelType.GuildText,
    topic: "Private staff coordination.",
  });
  await deleteLegacyJoinLog(guild);

  const owner = await guild.fetchOwner();
  if (!owner.roles.cache.has(roles.creator.id) && roles.creator.editable) {
    await owner.roles.add(roles.creator, MANAGED_REASON);
  }

  if (guild.systemChannelId !== channels.welcome.id) {
    await guild.setSystemChannel(channels.welcome, MANAGED_REASON);
  }
  const systemFlags = new Set(guild.systemChannelFlags.toArray());
  systemFlags.add("SuppressJoinNotifications");
  systemFlags.add("SuppressJoinNotificationReplies");
  await guild.setSystemChannelFlags([...systemFlags], MANAGED_REASON);

  await removeNativeJoinMessages(channels.general);

  await removeEmptyDefaultCategories(guild);

  await ensureSeedMessage(
    channels.welcome,
    "welcome-v1",
    baseEmbed(
      `Welcome to ${config.serverName}`,
      `MetaClicker is the main focus here, with space for XANENAX videos and the wider community.\n\n**Start here**\n• Download MetaClicker in <#${channels.downloads.id}>\n• Read <#${channels.rules.id}>\n• Get help in <#${channels.support.id}>\n• Play the daily Wordle in <#${channels.wordle.id}>`,
      "welcome-v1",
    ),
  );

  await ensureSeedMessage(
    channels.rules,
    "rules-v1",
    baseEmbed(
      "Community Rules",
      "1. Be respectful and keep discussions constructive.\n2. No spam, scams, malware, or unofficial download mirrors.\n3. Use the correct support and bug-report channels.\n4. Do not sell or re-upload MetaClicker as your own work.\n5. Follow Discord’s Terms of Service.",
      "rules-v1",
    ),
  );

  await ensureSeedMessage(
    channels.verify,
    "verify-v1",
    baseEmbed(
      "Verify to unlock the server",
      "Press the button below once. You will immediately get access to the MetaClicker, XANENAX, community, and voice channels.",
      "verify-v1",
    ),
    [
      new ActionRowBuilder().addComponents(
        new ButtonBuilder()
          .setCustomId("verify_member")
          .setLabel("Verify")
          .setStyle(ButtonStyle.Primary),
      ),
    ],
  );

  await ensureSeedMessage(
    channels.downloads,
    "downloads-v1",
    baseEmbed(
      "Official MetaClicker Download",
      `Download the latest Windows x64 release only from the official GitHub page:\n${config.releaseUrl}\n\nNever download builds sent through random DMs or unofficial mirrors.`,
      "downloads-v1",
    ),
  );

  await ensureSeedMessage(
    channels.youtube,
    "youtube-v1",
    baseEmbed(
      "XANENAX on YouTube",
      `Client tests, MetaClicker updates, and new videos:\n${config.youtubeUrl}`,
      "youtube-v1",
    ),
  );

  return { roles, categories, channels };
}

export function findManagedChannel(guild, name) {
  return guild.channels.cache.find(
    (channel) =>
      channel.type === ChannelType.GuildText && channel.name === name,
  );
}

export function findManagedRole(guild, name) {
  return guild.roles.cache.find(
    (role) => !role.managed && role.name === name,
  );
}

export const accentColor = ACCENT;
