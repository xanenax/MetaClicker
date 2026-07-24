using GithubClicker.Sample.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaClicker.usercontrol
{
    public partial class Settings : UserControl
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration

        public int r = 255;
        public int g = 192;
        public int b = 203;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void RGBSldValue_Tick(object sender, EventArgs e)
        {
            r = RSld.Value;
            g = GSld.Value;
            b = BSld.Value;

            RValue.Text = $"R: {r}";
            GValue.Text = $"G: {g}";
            BValue.Text = $"B: {b}";
        }

        private void HideBtn_Click(object sender, EventArgs e) => HideBtn.Text = "[...]";

       public int Hiide = 0;
        private void HideBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (HideBtn.Text.Contains("[...]"))
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        /* set to no key, because escape has been pressed*/
                        Hiide = 0;
                        HideBtn.Text = "[NONE]";
                        break;

                    default: /* default = any key that has been pressed */

                        Hiide = (int)e.KeyCode; /* set leftBind to the KeyCode (bind) */
                        HideBtn.Text = "[" + e.KeyCode + "]";
                        break;
                }
        }

       
    }
    }

