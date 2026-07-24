using GithubClicker.Sample.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaClicker.usercontrol
{
    public partial class LeftClicker : UserControl
    {

        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        public LeftClicker()
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
            siticoneCheckBox3.Location = new Point(8, 55);
            AlwsBtn.Location = new Point(160, 5);
            BrkBnt.Location = new Point(160, 30);
            RmbBtn.Location = new Point(160, 55);
            bindbtn.SetBounds(8, 76, 290, 32);

            foreach (Control option in new Control[]
            {
                smrtSwitch,
                ShiftBtn,
                siticoneCheckBox3,
                AlwsBtn,
                BrkBnt,
                RmbBtn
            })
            {
                option.BackColor = Branding.Surface;
            }
        }

        

        public int Biind = 0;
        private void bindbtn_Click(object sender, EventArgs e) => bindbtn.Text = "Press Any Key";

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
        bool isShifting;
        IntPtr hWnd;
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

            if (WinApi.GetAsyncKeyState(WinApi.VK_LBUTTON) < 0 && IsWhitelistedLeft() && !RmbBtn.Checked && !BrkBnt.Checked && smrtSwitch.Checked && !isShifting && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedLeft() && !RmbBtn.Checked && !isShifting && !BrkBnt.Checked && WinApi.GetAsyncKeyState(WinApi.VK_LBUTTON) < 0 || RmbBtn.Checked &&  IsWhitelistedLeft() && !BrkBnt.Checked && smrtSwitch.Checked && !isShifting && !ClickerExtensionHandle.InMenu() && MouseButtons == MouseButtons.Left || RmbBtn.Checked && IsWhitelistedLeft() && !BrkBnt.Checked && !smrtSwitch.Checked && !isShifting && MouseButtons == MouseButtons.Left)
            {
                PostMessage(hWnd, 0x0201, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, 0x0202, 0, 0);
            }

            else if (AlwsBtn.Checked && smrtSwitch.Checked && IsWhitelistedLeft() && !isShifting && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedLeft() && !isShifting && AlwsBtn.Checked)
            {
                PostMessage(hWnd, 0x0201, 0, 0);
                await Task.Delay(30);
                PostMessage(hWnd, 0x0202, 0, 0);
            }

            else if (WinApi.GetAsyncKeyState(WinApi.VK_LBUTTON) < 0 && IsWhitelistedLeft() && BrkBnt.Checked && smrtSwitch.Checked && !isShifting && !ClickerExtensionHandle.InMenu() || !smrtSwitch.Checked && IsWhitelistedLeft() && !isShifting && BrkBnt.Checked && WinApi.GetAsyncKeyState(WinApi.VK_LBUTTON) < 0)
            {
                WinApi.SendMessage(hWnd, 0x202, 0, 0);
                WinApi.SendMessage(hWnd, 0x201, 0, 0);
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

        private void siticoneCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox3.Checked)
            {
                CPSsld.Maximum = 35;
                yes.Maximum = 40;
            }
            if (!siticoneCheckBox3.Checked)
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

                IsWhitelistedLeft(); /* bool checking if the current left slot is whitelisted */

            }
        }

        private bool IsWhitelistedLeft()
        {
            switch (currentSlot)
            {
                /* switch statement, if current slot = 1, it will check for tgLeft checked and slot checked, if they are false, the slot will be considered as unwhitelisted */
                case 1: return ToggleLClicker.Checked && slotL1.Checked;
                case 2: return ToggleLClicker.Checked && slotL2.Checked;
                case 3: return ToggleLClicker.Checked && slotL3.Checked;
                case 4: return ToggleLClicker.Checked && slotL4.Checked;
                case 5: return ToggleLClicker.Checked && slotL5.Checked;
                case 6: return ToggleLClicker.Checked && slotL6.Checked;
                case 7: return ToggleLClicker.Checked && slotL7.Checked;
                case 8: return ToggleLClicker.Checked && slotL8.Checked;
                case 9: return ToggleLClicker.Checked && slotL9.Checked;
            }
            return false;
        }

        private void LeftClicker_Load(object sender, EventArgs e)
        {

        }

        private void ToggleLClicker_Click(object sender, EventArgs e)
        {

        }
    }
}
