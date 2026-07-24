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
            Branding.ApplyRoundedCorners(this, 18);
            BackColor = Branding.Background;
            siticoneGradientPanel1.Location = new Point(8, 8);
            siticoneGradientPanel1.Size = new Size(534, 49);
            Branding.StyleRoundedSurface(siticoneGradientPanel1, 10, Branding.Surface);
            Branding.StyleRoundedSurface(textBox, 12, Branding.Surface);
            logo.Visible = false;
            Branding.CreateMetallicMark(
                siticoneGradientPanel1,
                new Rectangle(245, 4, 43, 40));
            Branding.CreateWindowButton(
                siticoneGradientPanel1,
                "–",
                new Rectangle(472, 7, 25, 24),
                false,
                (sender, args) => WindowState = FormWindowState.Minimized);
            Branding.CreateWindowButton(
                siticoneGradientPanel1,
                "×",
                new Rectangle(500, 7, 25, 24),
                true,
                (sender, args) => Close());
            Label loaderTitle = Branding.CreateLabel(
                textBox,
                "META CLICKER",
                new Rectangle(12, 84, 308, 20),
                9f,
                FontStyle.Bold,
                Color.White,
                ContentAlignment.MiddleCenter);
            loaderTitle.BackColor = Branding.Surface;
            Branding.CreateMetallicMark(
                textBox,
                new Rectangle(126, 9, 80, 70));
            text.Bounds = new Rectangle(12, 116, 308, 20);
            text.BackColor = Branding.Surface;
            text.ForeColor = Branding.Muted;
            Branding.CreateSlashDecoration(
                this,
                new Rectangle(42, 115, 34, 24));
            Branding.CreateDotDecoration(
                this,
                new Rectangle(472, 151, 31, 23));
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
