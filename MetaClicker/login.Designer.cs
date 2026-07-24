namespace MetaClicker
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.logo = new System.Windows.Forms.Label();
            this.SettingsTab = new Siticone.UI.WinForms.SiticoneButton();
            this.RightClickerTab = new Siticone.UI.WinForms.SiticoneButton();
            this.LeftClickerTab = new Siticone.UI.WinForms.SiticoneButton();
            this.loginBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.textBox = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.text = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.siticoneGradientPanel1.SuspendLayout();
            this.textBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.BorderThickness = 1;
            this.siticoneGradientPanel1.Controls.Add(this.logo);
            this.siticoneGradientPanel1.Controls.Add(this.SettingsTab);
            this.siticoneGradientPanel1.Controls.Add(this.RightClickerTab);
            this.siticoneGradientPanel1.Controls.Add(this.LeftClickerTab);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(3, 2);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(543, 57);
            this.siticoneGradientPanel1.TabIndex = 1;
            this.siticoneGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticoneGradientPanel1_MouseDown);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Pink;
            this.logo.Location = new System.Drawing.Point(253, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(43, 37);
            this.logo.TabIndex = 1;
            this.logo.Text = "M";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.SettingsTab.BorderRadius = 5;
            this.SettingsTab.BorderThickness = 1;
            this.SettingsTab.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingsTab.CheckedState.BorderColor = System.Drawing.Color.Pink;
            this.SettingsTab.CheckedState.FillColor = System.Drawing.Color.Pink;
            this.SettingsTab.CheckedState.Parent = this.SettingsTab;
            this.SettingsTab.CustomImages.Parent = this.SettingsTab;
            this.SettingsTab.FillColor = System.Drawing.Color.Transparent;
            this.SettingsTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsTab.ForeColor = System.Drawing.Color.White;
            this.SettingsTab.HoveredState.BorderColor = System.Drawing.Color.Pink;
            this.SettingsTab.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.SettingsTab.HoveredState.Parent = this.SettingsTab;
            this.SettingsTab.Image = global::MetaClicker.Properties.Resources.output_onlinepngtools__2_;
            this.SettingsTab.ImageOffset = new System.Drawing.Point(1, 0);
            this.SettingsTab.ImageSize = new System.Drawing.Size(30, 30);
            this.SettingsTab.Location = new System.Drawing.Point(3, 201);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.PressedDepth = 0;
            this.SettingsTab.Size = new System.Drawing.Size(51, 51);
            this.SettingsTab.TabIndex = 3;
            // 
            // RightClickerTab
            // 
            this.RightClickerTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.RightClickerTab.BorderRadius = 5;
            this.RightClickerTab.BorderThickness = 1;
            this.RightClickerTab.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.RightClickerTab.CheckedState.BorderColor = System.Drawing.Color.Pink;
            this.RightClickerTab.CheckedState.FillColor = System.Drawing.Color.Pink;
            this.RightClickerTab.CheckedState.Parent = this.RightClickerTab;
            this.RightClickerTab.CustomImages.Parent = this.RightClickerTab;
            this.RightClickerTab.FillColor = System.Drawing.Color.Transparent;
            this.RightClickerTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RightClickerTab.ForeColor = System.Drawing.Color.White;
            this.RightClickerTab.HoveredState.BorderColor = System.Drawing.Color.Pink;
            this.RightClickerTab.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.RightClickerTab.HoveredState.Parent = this.RightClickerTab;
            this.RightClickerTab.Image = global::MetaClicker.Properties.Resources.mouse_right_click_50px;
            this.RightClickerTab.ImageOffset = new System.Drawing.Point(1, 0);
            this.RightClickerTab.ImageSize = new System.Drawing.Size(30, 30);
            this.RightClickerTab.Location = new System.Drawing.Point(3, 139);
            this.RightClickerTab.Name = "RightClickerTab";
            this.RightClickerTab.PressedDepth = 0;
            this.RightClickerTab.Size = new System.Drawing.Size(51, 51);
            this.RightClickerTab.TabIndex = 2;
            // 
            // LeftClickerTab
            // 
            this.LeftClickerTab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.LeftClickerTab.BorderRadius = 5;
            this.LeftClickerTab.BorderThickness = 1;
            this.LeftClickerTab.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.LeftClickerTab.Checked = true;
            this.LeftClickerTab.CheckedState.BorderColor = System.Drawing.Color.Pink;
            this.LeftClickerTab.CheckedState.FillColor = System.Drawing.Color.Pink;
            this.LeftClickerTab.CheckedState.Parent = this.LeftClickerTab;
            this.LeftClickerTab.CustomImages.Parent = this.LeftClickerTab;
            this.LeftClickerTab.FillColor = System.Drawing.Color.Transparent;
            this.LeftClickerTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LeftClickerTab.ForeColor = System.Drawing.Color.White;
            this.LeftClickerTab.HoveredState.BorderColor = System.Drawing.Color.Pink;
            this.LeftClickerTab.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.LeftClickerTab.HoveredState.Parent = this.LeftClickerTab;
            this.LeftClickerTab.Image = global::MetaClicker.Properties.Resources.left_click_50px_1;
            this.LeftClickerTab.ImageOffset = new System.Drawing.Point(1, 0);
            this.LeftClickerTab.ImageSize = new System.Drawing.Size(30, 30);
            this.LeftClickerTab.Location = new System.Drawing.Point(3, 77);
            this.LeftClickerTab.Name = "LeftClickerTab";
            this.LeftClickerTab.PressedDepth = 0;
            this.LeftClickerTab.Size = new System.Drawing.Size(51, 51);
            this.LeftClickerTab.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.CheckedState.ForeColor = System.Drawing.Color.Pink;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.DisabledState.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.HoverState.ForeColor = System.Drawing.Color.Pink;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(185, 239);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.loginBtn.Size = new System.Drawing.Size(180, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.Visible = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.textBox.BorderRadius = 5;
            this.textBox.BorderThickness = 1;
            this.textBox.Controls.Add(this.text);
            this.textBox.Location = new System.Drawing.Point(109, 82);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(332, 154);
            this.textBox.TabIndex = 4;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(108, 69);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(117, 17);
            this.text.TabIndex = 3;
            this.text.Text = "Starting";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta";
            this.Load += new System.EventHandler(this.login_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.textBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label logo;
        private Siticone.UI.WinForms.SiticoneButton SettingsTab;
        private Siticone.UI.WinForms.SiticoneButton RightClickerTab;
        private Siticone.UI.WinForms.SiticoneButton LeftClickerTab;
        private Siticone.Desktop.UI.WinForms.SiticoneButton loginBtn;
        private Siticone.UI.WinForms.SiticoneGradientPanel textBox;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Timer timer;
    }
}
