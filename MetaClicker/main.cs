using GithubClicker.Sample.Other;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaClicker
{
    public partial class main : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        private bool mouseDown;
        private Point offset;
        private bool rainbowActive;
        private double rainbowHue;
        private double rainbowSaturation;
        private double rainbowValue;

        public main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            leftClicker1.smrtSwitch.Checked = true;
            rightClicker1.smrtSwitch.Checked = true;
            rightClicker1.Hide();
            settings1.Hide();
            leftClicker1.BringToFront();

            timerR.Stop();
            timerG.Stop();
            timerB.Interval = 16;
            ApplyAccentColor(GetSelectedAccent());
        }

        private Color GetSelectedAccent()
        {
            return Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
        }

        private void ApplyAccentColor(Color accent)
        {
            logo.ForeColor = accent;
            leftClicker1.CPSsld.ThumbColor = accent;
            rightClicker1.CPSsld.ThumbColor = accent;

            var tabs = new[] { LeftClickerTab, RightClickerTab, SettingsTab };
            foreach (var tab in tabs)
            {
                tab.HoveredState.BorderColor = accent;
                tab.CheckedState.BorderColor = accent;
                tab.CheckedState.FillColor = accent;
            }

            var options = new[]
            {
                leftClicker1.smrtSwitch,
                leftClicker1.ShiftBtn,
                leftClicker1.siticoneCheckBox3,
                leftClicker1.RmbBtn,
                leftClicker1.BrkBnt,
                leftClicker1.AlwsBtn,
                rightClicker1.smrtSwitch,
                rightClicker1.ShiftBtn,
                rightClicker1.BlntBtn,
                rightClicker1.siticoneCheckBox4,
                rightClicker1.eatBtn,
                rightClicker1.AlwsBtn,
                settings1.RGBBtn,
                settings1.AlwaysontopBtn
            };

            foreach (var option in options)
            {
                option.CheckedState.BorderColor = accent;
                option.CheckedState.FillColor = accent;
            }

            var actionButtons = new[]
            {
                leftClicker1.bindbtn,
                leftClicker1.ToggleLClicker,
                rightClicker1.bindbtn,
                rightClicker1.ToggleLClicker,
                settings1.HideBtn,
                settings1.SelfdestructBtn
            };

            foreach (var button in actionButtons)
            {
                button.HoveredState.BorderColor = accent;
                button.CheckedState.BorderColor = accent;
                button.CheckedState.FillColor = accent;
            }

            var leftSlots = new[]
            {
                leftClicker1.slotL1, leftClicker1.slotL2, leftClicker1.slotL3,
                leftClicker1.slotL4, leftClicker1.slotL5, leftClicker1.slotL6,
                leftClicker1.slotL7, leftClicker1.slotL8, leftClicker1.slotL9
            };

            foreach (var slot in leftSlots)
            {
                slot.CheckedState.BorderColor = accent;
                slot.CheckedState.FillColor = accent;
            }

            var rightSlots = new[]
            {
                rightClicker1.slotR1, rightClicker1.slotR2, rightClicker1.slotR3,
                rightClicker1.slotR4, rightClicker1.slotR5, rightClicker1.slotR6,
                rightClicker1.slotR7, rightClicker1.slotR8, rightClicker1.slotR9
            };

            foreach (var slot in rightSlots)
            {
                slot.CheckedState.BorderColor = accent;
                slot.CheckedState.FillColor = accent;
            }

            settings1.RSld.ThumbColor = accent;
            settings1.GSld.ThumbColor = accent;
            settings1.BSld.ThumbColor = accent;
        }

        private void BeginRainbow()
        {
            Color baseColor = GetSelectedAccent();
            RgbToHsv(baseColor, out rainbowHue, out rainbowSaturation, out rainbowValue);
            ApplyAccentColor(baseColor);
            rainbowActive = true;
        }

        private void AdvanceRainbow()
        {
            if (!settings1.RGBBtn.Checked)
            {
                return;
            }

            if (!rainbowActive)
            {
                BeginRainbow();
                return;
            }

            rainbowHue = (rainbowHue + 0.65d) % 360d;
            ApplyAccentColor(HsvToColor(rainbowHue, rainbowSaturation, rainbowValue));
        }

        private static void RgbToHsv(Color color, out double hue, out double saturation, out double value)
        {
            double red = color.R / 255d;
            double green = color.G / 255d;
            double blue = color.B / 255d;
            double maximum = Math.Max(red, Math.Max(green, blue));
            double minimum = Math.Min(red, Math.Min(green, blue));
            double delta = maximum - minimum;

            if (delta == 0)
            {
                hue = 0;
            }
            else if (maximum == red)
            {
                hue = 60d * (((green - blue) / delta) % 6d);
            }
            else if (maximum == green)
            {
                hue = 60d * (((blue - red) / delta) + 2d);
            }
            else
            {
                hue = 60d * (((red - green) / delta) + 4d);
            }

            if (hue < 0)
            {
                hue += 360d;
            }

            saturation = maximum == 0 ? 0 : delta / maximum;
            value = maximum;
        }

        private static Color HsvToColor(double hue, double saturation, double value)
        {
            double chroma = value * saturation;
            double segment = hue / 60d;
            double secondary = chroma * (1d - Math.Abs((segment % 2d) - 1d));
            double red = 0;
            double green = 0;
            double blue = 0;

            if (segment < 1)
            {
                red = chroma;
                green = secondary;
            }
            else if (segment < 2)
            {
                red = secondary;
                green = chroma;
            }
            else if (segment < 3)
            {
                green = chroma;
                blue = secondary;
            }
            else if (segment < 4)
            {
                green = secondary;
                blue = chroma;
            }
            else if (segment < 5)
            {
                red = secondary;
                blue = chroma;
            }
            else
            {
                red = chroma;
                blue = secondary;
            }

            double match = value - chroma;
            return Color.FromArgb(
                (int)Math.Round((red + match) * 255d),
                (int)Math.Round((green + match) * 255d),
                (int)Math.Round((blue + match) * 255d));
        }

        private void main_Load(object sender, EventArgs e)
        {
        }

        private void siticoneGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void siticoneGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
            }
        }

        private void siticoneGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            leftClicker1.Show();
            leftClicker1.BringToFront();
            rightClicker1.Hide();
            settings1.Hide();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            rightClicker1.Show();
            rightClicker1.BringToFront();
            settings1.Hide();
            leftClicker1.Hide();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            settings1.Show();
            settings1.BringToFront();
            rightClicker1.Hide();
            leftClicker1.Hide();
        }

        private void colorTick_Tick(object sender, EventArgs e)
        {
            if (!settings1.RGBBtn.Checked)
            {
                ApplyAccentColor(GetSelectedAccent());
            }
        }

        private void utils_Tick(object sender, EventArgs e)
        {
            if (settings1.RGBBtn.Checked && !rainbowActive)
            {
                colorTick.Stop();
                BeginRainbow();
            }
            else if (!settings1.RGBBtn.Checked && rainbowActive)
            {
                rainbowActive = false;
                ApplyAccentColor(GetSelectedAccent());
                colorTick.Start();
            }

            TopMost = settings1.AlwaysontopBtn.Checked;

            if (WinApi.GetAsyncKeyState(settings1.Hiide) != 0)
            {
                if (ShowInTaskbar)
                {
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                    while (WinApi.GetAsyncKeyState(settings1.Hiide) != 0) Task.Delay(20);
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    ShowInTaskbar = true;
                    while (WinApi.GetAsyncKeyState(settings1.Hiide) != 0) Task.Delay(20);
                }
            }

            if (WinApi.GetAsyncKeyState(leftClicker1.Biind) != 0)
            {
                leftClicker1.ToggleLClicker.Checked = !leftClicker1.ToggleLClicker.Checked;
                while (WinApi.GetAsyncKeyState(leftClicker1.Biind) != 0) Task.Delay(20);
            }

            if (WinApi.GetAsyncKeyState(rightClicker1.Biind) != 0)
            {
                rightClicker1.ToggleLClicker.Checked = !rightClicker1.ToggleLClicker.Checked;
                while (WinApi.GetAsyncKeyState(rightClicker1.Biind) != 0) Task.Delay(20);
            }

            if (settings1.SelfdestructBtn.Checked)
            {
                foreach (Control currentControl in Controls)
                {
                    currentControl.Dispose();
                }

                Task.Delay(1000).Wait();
                Dispose();
                Environment.Exit(0);
            }
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            AdvanceRainbow();
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            AdvanceRainbow();
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            AdvanceRainbow();
        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void settings1_Load(object sender, EventArgs e)
        {
        }
    }
}
