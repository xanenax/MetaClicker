namespace MetaClicker
{
    partial class main
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
            this.utils = new System.Windows.Forms.Timer(this.components);
            this.leftClicker1 = new MetaClicker.usercontrol.LeftClicker();
            this.rightClicker1 = new MetaClicker.usercontrol.RightClicker();
            this.settings1 = new MetaClicker.usercontrol.Settings();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.colorTick = new System.Windows.Forms.Timer(this.components);
            this.siticoneGradientPanel1.SuspendLayout();
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
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(2, 2);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(57, 386);
            this.siticoneGradientPanel1.TabIndex = 0;
            this.siticoneGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneGradientPanel1_Paint);
            this.siticoneGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticoneGradientPanel1_MouseDown);
            this.siticoneGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticoneGradientPanel1_MouseMove);
            this.siticoneGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.siticoneGradientPanel1_MouseUp);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Pink;
            this.logo.Location = new System.Drawing.Point(8, 4);
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
            this.SettingsTab.Click += new System.EventHandler(this.siticoneButton3_Click);
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
            this.RightClickerTab.Click += new System.EventHandler(this.siticoneButton2_Click);
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
            this.LeftClickerTab.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // utils
            // 
            this.utils.Enabled = true;
            this.utils.Tick += new System.EventHandler(this.utils_Tick);
            // 
            // leftClicker1
            // 
            this.leftClicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.leftClicker1.Location = new System.Drawing.Point(118, 41);
            this.leftClicker1.Name = "leftClicker1";
            this.leftClicker1.Size = new System.Drawing.Size(314, 247);
            this.leftClicker1.TabIndex = 1;
            // 
            // rightClicker1
            // 
            this.rightClicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.rightClicker1.Location = new System.Drawing.Point(118, 41);
            this.rightClicker1.Name = "rightClicker1";
            this.rightClicker1.Size = new System.Drawing.Size(316, 247);
            this.rightClicker1.TabIndex = 2;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.settings1.Location = new System.Drawing.Point(117, 15);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(317, 273);
            this.settings1.TabIndex = 3;
            // 
            // timerR
            // 
            this.timerR.Interval = 5;
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // timerG
            // 
            this.timerG.Interval = 5;
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // timerB
            // 
            this.timerB.Enabled = true;
            this.timerB.Interval = 5;
            this.timerB.Tick += new System.EventHandler(this.timerB_Tick);
            // 
            // colorTick
            // 
            this.colorTick.Enabled = true;
            this.colorTick.Interval = 10;
            this.colorTick.Tick += new System.EventHandler(this.colorTick_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.leftClicker1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.rightClicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meta";
            this.Load += new System.EventHandler(this.main_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneButton LeftClickerTab;
        private Siticone.UI.WinForms.SiticoneButton RightClickerTab;
        private Siticone.UI.WinForms.SiticoneButton SettingsTab;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Timer utils;
        private usercontrol.LeftClicker leftClicker1;
        private usercontrol.RightClicker rightClicker1;
        private usercontrol.Settings settings1;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
        private System.Windows.Forms.Timer colorTick;
    }
}

