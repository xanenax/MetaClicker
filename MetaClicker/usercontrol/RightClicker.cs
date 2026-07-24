using GithubClicker.Sample.Other;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaClicker.usercontrol
{
    public partial class RightClicker : UserControl
    {
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public RightClicker()
        {
            InitializeComponent();
            Branding.StyleRoundedSurface(siticoneGradientPanel1, 12, Branding.Surface);
            Branding.StyleRoundedSurface(siticoneGradientPanel2, 12, Branding.Surface);
            ToggleLClicker.BorderRadius = 8;
            bindbtn.BorderRadius = 8;
            ToggleLClicker.SetBounds(8, 6, 290, 32);
            CpsValue.AutoSize = false;
            CpsValue.SetBounds(8, 41, 290, 17);
            CpsValue.BackColor = Branding.Surface;
            CPSsld.SetBounds(8, 61, 290, 11);
            Branding.StyleSlider(CPSsld, Branding.Surface);

            smrtSwitch.Location = new Point(8, 5);
            ShiftBtn.Location = new Point(8, 30);
            BlntBtn.Location = new Point(8, 55);
            AlwsBtn.Location = new Point(160, 5);
            eatBtn.Location = new Point(160, 30);
            siticoneCheckBox4.Location = new Point(160, 55);
            bindbtn.SetBounds(8, 76, 290, 32);

            foreach (Control option in new Control[]
            {
                smrtSwitch,
                ShiftBtn,
                BlntBtn,
                AlwsBtn,
                eatBtn,
                siticoneCheckBox4
            })
            {
                option.BackColor = Branding.Surface;
            }
        }
        private void utils_Tick(object sender, EventArgs e)
        {
            CpsValue.Text = $"CPS: {CPSsld.Value}";
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS1) != 0) currentSlot = 1;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS2) != 0) currentSlot = 2;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS3) != 0) currentSlot = 3;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS4) != 0) currentSlot = 4;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS5) != 0) currentSlot = 5;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS6) != 0) currentSlot = 6;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS7) != 0) currentSlot = 7;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS8) != 0) currentSlot = 8;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS9) != 0) currentSlot = 9;
        }
        private void bindbtn_Click(object sender, EventArgs e) => bindbtn.Text = "Press Any Key";

        public int Biind = 0;
        private void bindbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (bindbtn.Text.Contains("Press Any Key"))
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        /* set to no key, because escape has been pressed*/
                        Biind = 0;
                        bindbtn.Text = "bound to none";
                        break;

                    default: /* default = any key that has been pressed */

                        Biind = (int)e.KeyCode; /* set leftBind to the KeyCode (bind) */
                        bindbtn.Text = "[" + e.KeyCode + "]";
                        break;
                }
        }



        private void ToggleLClicker_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleLClicker.Checked)
            {
                ToggleLClicker.Text = "Disable";
            }
            else
            {
                ToggleLClicker.Text = "Enable";
            }
            if (ToggleLClicker.Checked)
            {
                Autoclicker.Start();
            }
            else
            {
                Autoclicker.Stop();
            }
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            int min = (int)CPSsld.Value - 3;
            int max = (int)CPSsld.Value + 3;

            Random yeet = new Random();
            yes.Value = yeet.Next(min, max);
        }
        IntPtr hWnd;
        bool isShifting;
        private async void Autoclicker_TickAsync(object sender, EventArgs e)
        {
            try
            {
                Autoclicker.Interval = 1000 / (int)yes.Value;
            }
            catch { }

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                hWnd = FindWindow(null, process.MainWindowTitle);
            }

            if (WinApi.GetAsyncKeyState(WinApi.VK_RBUTTON) < 0 && IsWhitelistedRight() && !eatBtn.Checked && !isShifting && smrtSwitch.Checked && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedRight() && !eatBtn.Checked && !isShifting && WinApi.GetAsyncKeyState(WinApi.VK_RBUTTON) < 0)
            {
                PostMessage(hWnd, 0x0204, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, 0x0205, 0, 0);
            }

            else if (AlwsBtn.Checked && IsWhitelistedRight() && smrtSwitch.Checked && !isShifting && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedRight() && !isShifting && AlwsBtn.Checked)
            {
                PostMessage(hWnd, 0x0204, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, 0x0205, 0, 0);
            }

            else if (WinApi.GetAsyncKeyState(WinApi.VK_RBUTTON) < 0 && IsWhitelistedRight() && eatBtn.Checked && smrtSwitch.Checked && !isShifting && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedRight() && !isShifting && eatBtn.Checked && WinApi.GetAsyncKeyState(WinApi.VK_RBUTTON) < 0)
            {
                WinApi.SendMessage(hWnd, 0x0205, 0, 0);
                WinApi.SendMessage(hWnd, 0x0204, 0, 0);
            }

            if (ShiftBtn.Checked)
            {
                if (GetAsyncKeyState(Keys.LShiftKey) < 0)
                {
                    isShifting = true;
                }
                else
                {
                    isShifting = false;
                }
            }
        }

        private void BlntBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BlntBtn.Checked)
            {
                CPSsld.Maximum = 35;
                yes.Maximum = 40;
            }
            if (!BlntBtn.Checked)
            {
                CPSsld.Maximum = 15;
                yes.Maximum = 20;
                CPSsld.Value = 10;
            }
        }
        private byte currentSlot = 1;
        private async void GetSlots()
        {
            for (; ; )
            {
                await Task.Delay(50);

                /* get pressed key to get current slot position */


                IsWhitelistedRight(); /* same but for right click */
            }
        }

        private bool IsWhitelistedRight()
        {
            switch (currentSlot)
            {
                /* same thing but for right clicker */
                case 1: return ToggleLClicker.Checked && slotR1.Checked;
                case 2: return ToggleLClicker.Checked && slotR2.Checked;
                case 3: return ToggleLClicker.Checked && slotR3.Checked;
                case 4: return ToggleLClicker.Checked && slotR4.Checked;
                case 5: return ToggleLClicker.Checked && slotR5.Checked;
                case 6: return ToggleLClicker.Checked && slotR6.Checked;
                case 7: return ToggleLClicker.Checked && slotR7.Checked;
                case 8: return ToggleLClicker.Checked && slotR8.Checked;
                case 9: return ToggleLClicker.Checked && slotR9.Checked;
            }
            return false;
        }

        private void AlwsBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
