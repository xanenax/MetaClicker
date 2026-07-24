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
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        bool mouseDown;
        private Point offset;
       
        public main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            leftClicker1.smrtSwitch.Checked = true;
            rightClicker1.smrtSwitch.Checked = true;
            rightClicker1.Hide();
            settings1.Hide();
            leftClicker1.BringToFront();
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
            if (mouseDown == true)
            {
                Point currentSreenPos = PointToScreen(e.Location);
                Location = new Point(currentSreenPos.X - offset.X, currentSreenPos.Y - offset.Y);
            }
        }

        private void siticoneGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            leftClicker1.Show();
            leftClicker1.BringToFront();
            rightClicker1.Hide();
            settings1.Hide();
        }

        private void colorTick_Tick(object sender, EventArgs e)
        {
            logo.ForeColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.CPSsld.ThumbColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.CPSsld.ThumbColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            RightClickerTab.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            SettingsTab.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            RightClickerTab.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            LeftClickerTab.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            SettingsTab.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            RightClickerTab.CheckedState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            SettingsTab.CheckedState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.RSld.ThumbColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.GSld.ThumbColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.BSld.ThumbColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
            settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(settings1.RSld.Value, settings1.GSld.Value, settings1.BSld.Value);
        }

        private void utils_Tick(object sender, EventArgs e)
        {
           if (settings1.RGBBtn.Checked)
            {
                colorTick.Stop();
            }
           if (!settings1.RGBBtn.Checked)
            {
                colorTick.Start();
            }

            if (settings1.RGBBtn.Checked)
            {
                
            }
            if (!settings1.RGBBtn.Checked)
            {
                
            }


            if (settings1.AlwaysontopBtn.Checked)
            {
                this.TopMost = true;
            }
            if (!settings1.AlwaysontopBtn.Checked)
            {
                this.TopMost = false;
            }

            if (WinApi.GetAsyncKeyState(settings1.Hiide) != 0)
            {
                if (ShowInTaskbar == true)
                {
                    this.WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                    while (WinApi.GetAsyncKeyState(settings1.Hiide) != 0) Task.Delay(20);
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
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

            if(settings1.SelfdestructBtn.Checked)
            {
                foreach (Control currentControl in Controls)
                {
                    currentControl.Dispose(); /* gets each control in Controls and disposes them */
                }

                Task.Delay(1000).Wait();

                this.Dispose();
                Environment.Exit(0); /* exit */
            }
        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int r = 244;
        int g = 65;
        int b = 65;

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (settings1.RGBBtn.Checked)
            {
                if (b >= 244)
                {

                    r -= 1;

                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);


                    if (r <= 65)
                    {
                        timerR.Stop();
                        timerG.Start();


                    }

                }

                if (b <= 65)
                {
                    r += 1;

                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);


                    if (r >= 244)
                    {
                        timerR.Stop();
                        timerG.Start();


                    }
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (settings1.RGBBtn.Checked)
            {
                if (r <= 65)
                {
                    g += 1;

                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);

                    if (g >= 244)
                    {
                        timerG.Stop();
                        timerB.Start();


                    }
                }

                if (r >= 244)
                {
                    g -= 1;

                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);

                    if (g <= 65)
                    {
                        timerG.Stop();
                        timerB.Start();


                    }
                }
            }

        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (settings1.RGBBtn.Checked)
            {
                if (g <= 65)
                {
                    b += 1;


                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);

                    if (b >= 244)
                    {
                        timerB.Stop();
                        timerR.Start();


                    }
                }

                if (g >= 244)
                {
                    b -= 1;


                    logo.ForeColor = Color.FromArgb(r, g, b);
                    leftClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    rightClicker1.CPSsld.ThumbColor = Color.FromArgb(r, g, b);
                    RightClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    RightClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    LeftClickerTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    SettingsTab.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.BlntBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.siticoneCheckBox4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.eatBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.smrtSwitch.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ShiftBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.siticoneCheckBox3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.RmbBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.BrkBnt.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.AlwsBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.bindbtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    rightClicker1.ToggleLClicker.CheckedState.BorderColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    leftClicker1.slotL9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR1.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR2.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR3.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR4.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR5.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR6.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR7.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR8.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    rightClicker1.slotR9.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RGBBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.AlwaysontopBtn.CheckedState.FillColor = Color.FromArgb(r, g, b);
                    settings1.RSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.GSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.BSld.ThumbColor = Color.FromArgb(r, g, b);
                    settings1.HideBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);
                    settings1.SelfdestructBtn.HoveredState.BorderColor = Color.FromArgb(r, g, b);

                    if (b <= 65)
                    {
                        timerB.Stop();
                        timerR.Start();


                    }
                }

            }

        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
