using GithubClicker.Sample.Other;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MetaClicker
{
    public partial class login : Form
    {
        private int startupStep;
        private bool mainOpened;

        public login()
        {
            InitializeComponent();
            Region = Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            timer.Stop();
            timer.Interval = 250;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            OpenMain();
        }

        private void login_Load(object sender, EventArgs e)
        {
            startupStep = 0;
            text.Text = "Starting";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            startupStep++;

            if (startupStep < 5)
            {
                text.Text = "Starting" + new string('.', startupStep);
                return;
            }

            timer.Stop();
            OpenMain();
        }

        private void OpenMain()
        {
            if (mainOpened)
            {
                return;
            }

            mainOpened = true;
            main mainForm = new main();
            mainForm.FormClosed += (sender, args) => Close();
            mainForm.Show();
            Hide();
        }

        private void siticoneGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinApi.ReleaseCapture();
                WinApi.SendMessage(Handle, WinApi.WM_NCLBUTTONDOWN, WinApi.HT_CAPTION, 0);
            }
        }
    }
}
