namespace MetaClicker.usercontrol
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneGradientPanel2 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.SelfdestructBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.AlwaysontopBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.HideBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.BSld = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.BValue = new System.Windows.Forms.Label();
            this.GSld = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.GValue = new System.Windows.Forms.Label();
            this.RSld = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.RValue = new System.Windows.Forms.Label();
            this.RGBSldValue = new System.Windows.Forms.Timer(this.components);
            this.utils = new System.Windows.Forms.Timer(this.components);
            this.RGBBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneGradientPanel2.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.siticoneGradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(79)))));
            this.siticoneGradientPanel2.BorderRadius = 5;
            this.siticoneGradientPanel2.BorderThickness = 1;
            this.siticoneGradientPanel2.Controls.Add(this.SelfdestructBtn);
            this.siticoneGradientPanel2.Controls.Add(this.RGBBtn);
            this.siticoneGradientPanel2.Controls.Add(this.AlwaysontopBtn);
            this.siticoneGradientPanel2.Controls.Add(this.HideBtn);
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(53, 141);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(207, 128);
            this.siticoneGradientPanel2.TabIndex = 6;
            // 
            // SelfdestructBtn
            // 
            this.SelfdestructBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.SelfdestructBtn.BorderRadius = 5;
            this.SelfdestructBtn.BorderThickness = 1;
            this.SelfdestructBtn.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.SelfdestructBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.SelfdestructBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.SelfdestructBtn.CheckedState.Parent = this.SelfdestructBtn;
            this.SelfdestructBtn.CustomImages.Parent = this.SelfdestructBtn;
            this.SelfdestructBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.SelfdestructBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelfdestructBtn.ForeColor = System.Drawing.Color.White;
            this.SelfdestructBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.SelfdestructBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.SelfdestructBtn.HoveredState.Parent = this.SelfdestructBtn;
            this.SelfdestructBtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.SelfdestructBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SelfdestructBtn.Location = new System.Drawing.Point(15, 46);
            this.SelfdestructBtn.Name = "SelfdestructBtn";
            this.SelfdestructBtn.PressedDepth = 0;
            this.SelfdestructBtn.Size = new System.Drawing.Size(178, 32);
            this.SelfdestructBtn.TabIndex = 7;
            this.SelfdestructBtn.Text = "Self Destruct";
            // 
            // AlwaysontopBtn
            // 
            this.AlwaysontopBtn.AutoSize = true;
            this.AlwaysontopBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.AlwaysontopBtn.CheckedState.BorderRadius = 3;
            this.AlwaysontopBtn.CheckedState.BorderThickness = 0;
            this.AlwaysontopBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.AlwaysontopBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysontopBtn.ForeColor = System.Drawing.Color.White;
            this.AlwaysontopBtn.Location = new System.Drawing.Point(15, 83);
            this.AlwaysontopBtn.Name = "AlwaysontopBtn";
            this.AlwaysontopBtn.Size = new System.Drawing.Size(101, 19);
            this.AlwaysontopBtn.TabIndex = 0;
            this.AlwaysontopBtn.Text = "Always on top";
            this.AlwaysontopBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.AlwaysontopBtn.UncheckedState.BorderRadius = 3;
            this.AlwaysontopBtn.UncheckedState.BorderThickness = 0;
            this.AlwaysontopBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            // 
            // HideBtn
            // 
            this.HideBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.HideBtn.BorderRadius = 5;
            this.HideBtn.BorderThickness = 1;
            this.HideBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.HideBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.HideBtn.CheckedState.Parent = this.HideBtn;
            this.HideBtn.CustomImages.Parent = this.HideBtn;
            this.HideBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.HideBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HideBtn.ForeColor = System.Drawing.Color.White;
            this.HideBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.HideBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.HideBtn.HoveredState.Parent = this.HideBtn;
            this.HideBtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.HideBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.HideBtn.Location = new System.Drawing.Point(15, 8);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.PressedDepth = 0;
            this.HideBtn.Size = new System.Drawing.Size(178, 32);
            this.HideBtn.TabIndex = 6;
            this.HideBtn.Text = "Hide";
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            this.HideBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HideBtn_KeyDown);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(29)))), ((int)(((byte)(79)))));
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.BorderThickness = 1;
            this.siticoneGradientPanel1.Controls.Add(this.BSld);
            this.siticoneGradientPanel1.Controls.Add(this.BValue);
            this.siticoneGradientPanel1.Controls.Add(this.GSld);
            this.siticoneGradientPanel1.Controls.Add(this.GValue);
            this.siticoneGradientPanel1.Controls.Add(this.RSld);
            this.siticoneGradientPanel1.Controls.Add(this.RValue);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(306, 128);
            this.siticoneGradientPanel1.TabIndex = 5;
            // 
            // BSld
            // 
            this.BSld.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(42)))));
            this.BSld.HoveredState.Parent = this.BSld;
            this.BSld.IndicateFocus = false;
            this.BSld.Location = new System.Drawing.Point(1, 92);
            this.BSld.Maximum = 255;
            this.BSld.Name = "BSld";
            this.BSld.Size = new System.Drawing.Size(303, 23);
            this.BSld.TabIndex = 9;
            this.BSld.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.BSld.Value = 255;
            // 
            // BValue
            // 
            this.BValue.AutoSize = true;
            this.BValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BValue.ForeColor = System.Drawing.Color.White;
            this.BValue.Location = new System.Drawing.Point(4, 77);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(43, 17);
            this.BValue.TabIndex = 8;
            this.BValue.Text = "B: 255";
            // 
            // GSld
            // 
            this.GSld.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(42)))));
            this.GSld.HoveredState.Parent = this.GSld;
            this.GSld.IndicateFocus = false;
            this.GSld.Location = new System.Drawing.Point(1, 55);
            this.GSld.Maximum = 255;
            this.GSld.Name = "GSld";
            this.GSld.Size = new System.Drawing.Size(303, 23);
            this.GSld.TabIndex = 7;
            this.GSld.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.GSld.Value = 61;
            // 
            // GValue
            // 
            this.GValue.AutoSize = true;
            this.GValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GValue.ForeColor = System.Drawing.Color.White;
            this.GValue.Location = new System.Drawing.Point(4, 40);
            this.GValue.Name = "GValue";
            this.GValue.Size = new System.Drawing.Size(45, 17);
            this.GValue.TabIndex = 6;
            this.GValue.Text = "G: 61";
            // 
            // RSld
            // 
            this.RSld.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(15)))), ((int)(((byte)(42)))));
            this.RSld.HoveredState.Parent = this.RSld;
            this.RSld.IndicateFocus = false;
            this.RSld.Location = new System.Drawing.Point(1, 20);
            this.RSld.Maximum = 255;
            this.RSld.Name = "RSld";
            this.RSld.Size = new System.Drawing.Size(303, 23);
            this.RSld.TabIndex = 5;
            this.RSld.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.RSld.Value = 139;
            // 
            // RValue
            // 
            this.RValue.AutoSize = true;
            this.RValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RValue.ForeColor = System.Drawing.Color.White;
            this.RValue.Location = new System.Drawing.Point(4, 5);
            this.RValue.Name = "RValue";
            this.RValue.Size = new System.Drawing.Size(44, 17);
            this.RValue.TabIndex = 2;
            this.RValue.Text = "R: 139";
            // 
            // RGBSldValue
            // 
            this.RGBSldValue.Enabled = true;
            this.RGBSldValue.Interval = 1;
            this.RGBSldValue.Tick += new System.EventHandler(this.RGBSldValue_Tick);
            // 
            // utils
            // 
            this.utils.Enabled = true;
            // 
            // RGBBtn
            // 
            this.RGBBtn.AutoSize = true;
            this.RGBBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.RGBBtn.CheckedState.BorderRadius = 3;
            this.RGBBtn.CheckedState.BorderThickness = 0;
            this.RGBBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(61)))), ((int)(((byte)(255)))));
            this.RGBBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBBtn.ForeColor = System.Drawing.Color.White;
            this.RGBBtn.Location = new System.Drawing.Point(15, 105);
            this.RGBBtn.Name = "RGBBtn";
            this.RGBBtn.Size = new System.Drawing.Size(106, 19);
            this.RGBBtn.TabIndex = 0;
            this.RGBBtn.Text = "RGB fade";
            this.RGBBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.RGBBtn.UncheckedState.BorderRadius = 3;
            this.RGBBtn.UncheckedState.BorderThickness = 0;
            this.RGBBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(317, 288);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label RValue;
        private System.Windows.Forms.Label BValue;
        private System.Windows.Forms.Label GValue;
        private System.Windows.Forms.Timer RGBSldValue;
        public Siticone.UI.WinForms.SiticoneCheckBox AlwaysontopBtn;
        public Siticone.UI.WinForms.SiticoneMetroTrackBar RSld;
        public Siticone.UI.WinForms.SiticoneMetroTrackBar BSld;
        public Siticone.UI.WinForms.SiticoneMetroTrackBar GSld;
        private System.Windows.Forms.Timer utils;
        public Siticone.UI.WinForms.SiticoneButton SelfdestructBtn;
        public Siticone.UI.WinForms.SiticoneCheckBox RGBBtn;
        public Siticone.UI.WinForms.SiticoneButton HideBtn;
    }
}
