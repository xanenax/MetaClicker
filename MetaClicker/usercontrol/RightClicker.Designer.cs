namespace MetaClicker.usercontrol
{
    partial class RightClicker
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
            this.bindbtn = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneCheckBox4 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.eatBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.AlwsBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.BlntBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.ShiftBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.smrtSwitch = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.CPSsld = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.ToggleLClicker = new Siticone.UI.WinForms.SiticoneButton();
            this.CpsValue = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.utils = new System.Windows.Forms.Timer(this.components);
            this.yes = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.slotR9 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR8 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR7 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR6 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR5 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR4 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR3 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR2 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.slotR1 = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.siticoneGradientPanel2.SuspendLayout();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.siticoneGradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.siticoneGradientPanel2.BorderRadius = 5;
            this.siticoneGradientPanel2.BorderThickness = 1;
            this.siticoneGradientPanel2.Controls.Add(this.bindbtn);
            this.siticoneGradientPanel2.Controls.Add(this.siticoneCheckBox4);
            this.siticoneGradientPanel2.Controls.Add(this.eatBtn);
            this.siticoneGradientPanel2.Controls.Add(this.AlwsBtn);
            this.siticoneGradientPanel2.Controls.Add(this.BlntBtn);
            this.siticoneGradientPanel2.Controls.Add(this.ShiftBtn);
            this.siticoneGradientPanel2.Controls.Add(this.smrtSwitch);
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(3, 83);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(306, 113);
            this.siticoneGradientPanel2.TabIndex = 6;
            // 
            // bindbtn
            // 
            this.bindbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.bindbtn.BorderRadius = 5;
            this.bindbtn.BorderThickness = 1;
            this.bindbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.bindbtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.bindbtn.CheckedState.Parent = this.bindbtn;
            this.bindbtn.CustomImages.Parent = this.bindbtn;
            this.bindbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.bindbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindbtn.ForeColor = System.Drawing.Color.White;
            this.bindbtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.bindbtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.bindbtn.HoveredState.Parent = this.bindbtn;
            this.bindbtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.bindbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.bindbtn.Location = new System.Drawing.Point(2, 78);
            this.bindbtn.Name = "bindbtn";
            this.bindbtn.PressedDepth = 0;
            this.bindbtn.Size = new System.Drawing.Size(303, 32);
            this.bindbtn.TabIndex = 6;
            this.bindbtn.Text = "Bound to none";
            this.bindbtn.Click += new System.EventHandler(this.bindbtn_Click);
            this.bindbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindbtn_KeyDown);
            // 
            // siticoneCheckBox4
            // 
            this.siticoneCheckBox4.AutoSize = true;
            this.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.CheckedState.BorderRadius = 3;
            this.siticoneCheckBox4.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox4.ForeColor = System.Drawing.Color.White;
            this.siticoneCheckBox4.Location = new System.Drawing.Point(164, 54);
            this.siticoneCheckBox4.Name = "siticoneCheckBox4";
            this.siticoneCheckBox4.Size = new System.Drawing.Size(67, 19);
            this.siticoneCheckBox4.TabIndex = 5;
            this.siticoneCheckBox4.Text = "Module";
            this.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.siticoneCheckBox4.UncheckedState.BorderRadius = 3;
            this.siticoneCheckBox4.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            // 
            // eatBtn
            // 
            this.eatBtn.AutoSize = true;
            this.eatBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.eatBtn.CheckedState.BorderRadius = 3;
            this.eatBtn.CheckedState.BorderThickness = 0;
            this.eatBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.eatBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatBtn.ForeColor = System.Drawing.Color.White;
            this.eatBtn.Location = new System.Drawing.Point(164, 29);
            this.eatBtn.Name = "eatBtn";
            this.eatBtn.Size = new System.Drawing.Size(117, 19);
            this.eatBtn.TabIndex = 4;
            this.eatBtn.Text = "Eat while clicking";
            this.eatBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.eatBtn.UncheckedState.BorderRadius = 3;
            this.eatBtn.UncheckedState.BorderThickness = 0;
            this.eatBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            // 
            // AlwsBtn
            // 
            this.AlwsBtn.AutoSize = true;
            this.AlwsBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.AlwsBtn.CheckedState.BorderRadius = 3;
            this.AlwsBtn.CheckedState.BorderThickness = 0;
            this.AlwsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.AlwsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwsBtn.ForeColor = System.Drawing.Color.White;
            this.AlwsBtn.Location = new System.Drawing.Point(163, 4);
            this.AlwsBtn.Name = "AlwsBtn";
            this.AlwsBtn.Size = new System.Drawing.Size(80, 19);
            this.AlwsBtn.TabIndex = 3;
            this.AlwsBtn.Text = "Always on";
            this.AlwsBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.AlwsBtn.UncheckedState.BorderRadius = 3;
            this.AlwsBtn.UncheckedState.BorderThickness = 0;
            this.AlwsBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.AlwsBtn.CheckedChanged += new System.EventHandler(this.AlwsBtn_CheckedChanged);
            // 
            // BlntBtn
            // 
            this.BlntBtn.AutoSize = true;
            this.BlntBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.BlntBtn.CheckedState.BorderRadius = 3;
            this.BlntBtn.CheckedState.BorderThickness = 0;
            this.BlntBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.BlntBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlntBtn.ForeColor = System.Drawing.Color.White;
            this.BlntBtn.Location = new System.Drawing.Point(7, 56);
            this.BlntBtn.Name = "BlntBtn";
            this.BlntBtn.Size = new System.Drawing.Size(63, 19);
            this.BlntBtn.TabIndex = 2;
            this.BlntBtn.Text = "Blatant";
            this.BlntBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.BlntBtn.UncheckedState.BorderRadius = 3;
            this.BlntBtn.UncheckedState.BorderThickness = 0;
            this.BlntBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.BlntBtn.CheckedChanged += new System.EventHandler(this.BlntBtn_CheckedChanged);
            // 
            // ShiftBtn
            // 
            this.ShiftBtn.AutoSize = true;
            this.ShiftBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.ShiftBtn.CheckedState.BorderRadius = 3;
            this.ShiftBtn.CheckedState.BorderThickness = 0;
            this.ShiftBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.ShiftBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftBtn.ForeColor = System.Drawing.Color.White;
            this.ShiftBtn.Location = new System.Drawing.Point(7, 31);
            this.ShiftBtn.Name = "ShiftBtn";
            this.ShiftBtn.Size = new System.Drawing.Size(90, 19);
            this.ShiftBtn.TabIndex = 1;
            this.ShiftBtn.Text = "Shift disable";
            this.ShiftBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.ShiftBtn.UncheckedState.BorderRadius = 3;
            this.ShiftBtn.UncheckedState.BorderThickness = 0;
            this.ShiftBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            // 
            // smrtSwitch
            // 
            this.smrtSwitch.AutoSize = true;
            this.smrtSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.smrtSwitch.CheckedState.BorderRadius = 3;
            this.smrtSwitch.CheckedState.BorderThickness = 0;
            this.smrtSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.smrtSwitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smrtSwitch.ForeColor = System.Drawing.Color.White;
            this.smrtSwitch.Location = new System.Drawing.Point(6, 6);
            this.smrtSwitch.Name = "smrtSwitch";
            this.smrtSwitch.Size = new System.Drawing.Size(91, 19);
            this.smrtSwitch.TabIndex = 0;
            this.smrtSwitch.Text = "Smart mode";
            this.smrtSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.smrtSwitch.UncheckedState.BorderRadius = 3;
            this.smrtSwitch.UncheckedState.BorderThickness = 0;
            this.smrtSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.siticoneGradientPanel1.BorderRadius = 5;
            this.siticoneGradientPanel1.BorderThickness = 1;
            this.siticoneGradientPanel1.Controls.Add(this.CPSsld);
            this.siticoneGradientPanel1.Controls.Add(this.ToggleLClicker);
            this.siticoneGradientPanel1.Controls.Add(this.CpsValue);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(306, 78);
            this.siticoneGradientPanel1.TabIndex = 5;
            // 
            // CPSsld
            // 
            this.CPSsld.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.CPSsld.HoveredState.Parent = this.CPSsld;
            this.CPSsld.IndicateFocus = false;
            this.CPSsld.Location = new System.Drawing.Point(2, 59);
            this.CPSsld.Maximum = 15;
            this.CPSsld.Minimum = 3;
            this.CPSsld.Name = "CPSsld";
            this.CPSsld.Size = new System.Drawing.Size(302, 11);
            this.CPSsld.TabIndex = 5;
            this.CPSsld.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.CPSsld.Value = 10;
            // 
            // ToggleLClicker
            // 
            this.ToggleLClicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.ToggleLClicker.BorderRadius = 5;
            this.ToggleLClicker.BorderThickness = 1;
            this.ToggleLClicker.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.ToggleLClicker.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.ToggleLClicker.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.ToggleLClicker.CheckedState.Parent = this.ToggleLClicker;
            this.ToggleLClicker.CustomImages.Parent = this.ToggleLClicker;
            this.ToggleLClicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.ToggleLClicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToggleLClicker.ForeColor = System.Drawing.Color.White;
            this.ToggleLClicker.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.ToggleLClicker.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.ToggleLClicker.HoveredState.Parent = this.ToggleLClicker;
            this.ToggleLClicker.ImageOffset = new System.Drawing.Point(1, 0);
            this.ToggleLClicker.ImageSize = new System.Drawing.Size(30, 30);
            this.ToggleLClicker.Location = new System.Drawing.Point(2, 2);
            this.ToggleLClicker.Name = "ToggleLClicker";
            this.ToggleLClicker.PressedDepth = 0;
            this.ToggleLClicker.Size = new System.Drawing.Size(303, 32);
            this.ToggleLClicker.TabIndex = 3;
            this.ToggleLClicker.Text = "Enable";
            this.ToggleLClicker.CheckedChanged += new System.EventHandler(this.ToggleLClicker_CheckedChanged);
            // 
            // CpsValue
            // 
            this.CpsValue.AutoSize = true;
            this.CpsValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpsValue.ForeColor = System.Drawing.Color.White;
            this.CpsValue.Location = new System.Drawing.Point(1, 39);
            this.CpsValue.Name = "CpsValue";
            this.CpsValue.Size = new System.Drawing.Size(51, 17);
            this.CpsValue.TabIndex = 2;
            this.CpsValue.Text = "CPS: 10";
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 1000;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_TickAsync);
            // 
            // utils
            // 
            this.utils.Enabled = true;
            this.utils.Interval = 1;
            this.utils.Tick += new System.EventHandler(this.utils_Tick);
            // 
            // yes
            // 
            this.yes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.yes.HoveredState.Parent = this.yes;
            this.yes.IndicateFocus = false;
            this.yes.Location = new System.Drawing.Point(5, 202);
            this.yes.Maximum = 20;
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(302, 11);
            this.yes.TabIndex = 6;
            this.yes.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.yes.Value = 10;
            this.yes.Visible = false;
            // 
            // slotR9
            // 
            this.slotR9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR9.Checked = true;
            this.slotR9.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR9.CheckedState.BorderRadius = 2;
            this.slotR9.CheckedState.BorderThickness = 0;
            this.slotR9.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR9.CheckedState.Parent = this.slotR9;
            this.slotR9.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR9.Location = new System.Drawing.Point(234, 219);
            this.slotR9.Name = "slotR9";
            this.slotR9.Size = new System.Drawing.Size(15, 15);
            this.slotR9.TabIndex = 17;
            this.slotR9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR9.UncheckedState.BorderRadius = 2;
            this.slotR9.UncheckedState.BorderThickness = 0;
            this.slotR9.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR9.UncheckedState.Parent = this.slotR9;
            // 
            // slotR8
            // 
            this.slotR8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR8.Checked = true;
            this.slotR8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR8.CheckedState.BorderRadius = 2;
            this.slotR8.CheckedState.BorderThickness = 0;
            this.slotR8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR8.CheckedState.Parent = this.slotR8;
            this.slotR8.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR8.Location = new System.Drawing.Point(213, 219);
            this.slotR8.Name = "slotR8";
            this.slotR8.Size = new System.Drawing.Size(15, 15);
            this.slotR8.TabIndex = 18;
            this.slotR8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR8.UncheckedState.BorderRadius = 2;
            this.slotR8.UncheckedState.BorderThickness = 0;
            this.slotR8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR8.UncheckedState.Parent = this.slotR8;
            // 
            // slotR7
            // 
            this.slotR7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR7.Checked = true;
            this.slotR7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR7.CheckedState.BorderRadius = 2;
            this.slotR7.CheckedState.BorderThickness = 0;
            this.slotR7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR7.CheckedState.Parent = this.slotR7;
            this.slotR7.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR7.Location = new System.Drawing.Point(192, 219);
            this.slotR7.Name = "slotR7";
            this.slotR7.Size = new System.Drawing.Size(15, 15);
            this.slotR7.TabIndex = 19;
            this.slotR7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR7.UncheckedState.BorderRadius = 2;
            this.slotR7.UncheckedState.BorderThickness = 0;
            this.slotR7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR7.UncheckedState.Parent = this.slotR7;
            // 
            // slotR6
            // 
            this.slotR6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR6.Checked = true;
            this.slotR6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR6.CheckedState.BorderRadius = 2;
            this.slotR6.CheckedState.BorderThickness = 0;
            this.slotR6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR6.CheckedState.Parent = this.slotR6;
            this.slotR6.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR6.Location = new System.Drawing.Point(171, 219);
            this.slotR6.Name = "slotR6";
            this.slotR6.Size = new System.Drawing.Size(15, 15);
            this.slotR6.TabIndex = 20;
            this.slotR6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR6.UncheckedState.BorderRadius = 2;
            this.slotR6.UncheckedState.BorderThickness = 0;
            this.slotR6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR6.UncheckedState.Parent = this.slotR6;
            // 
            // slotR5
            // 
            this.slotR5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR5.Checked = true;
            this.slotR5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR5.CheckedState.BorderRadius = 2;
            this.slotR5.CheckedState.BorderThickness = 0;
            this.slotR5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR5.CheckedState.Parent = this.slotR5;
            this.slotR5.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR5.Location = new System.Drawing.Point(150, 219);
            this.slotR5.Name = "slotR5";
            this.slotR5.Size = new System.Drawing.Size(15, 15);
            this.slotR5.TabIndex = 21;
            this.slotR5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR5.UncheckedState.BorderRadius = 2;
            this.slotR5.UncheckedState.BorderThickness = 0;
            this.slotR5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR5.UncheckedState.Parent = this.slotR5;
            // 
            // slotR4
            // 
            this.slotR4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR4.Checked = true;
            this.slotR4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR4.CheckedState.BorderRadius = 2;
            this.slotR4.CheckedState.BorderThickness = 0;
            this.slotR4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR4.CheckedState.Parent = this.slotR4;
            this.slotR4.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR4.Location = new System.Drawing.Point(129, 219);
            this.slotR4.Name = "slotR4";
            this.slotR4.Size = new System.Drawing.Size(15, 15);
            this.slotR4.TabIndex = 22;
            this.slotR4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR4.UncheckedState.BorderRadius = 2;
            this.slotR4.UncheckedState.BorderThickness = 0;
            this.slotR4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR4.UncheckedState.Parent = this.slotR4;
            // 
            // slotR3
            // 
            this.slotR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR3.Checked = true;
            this.slotR3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR3.CheckedState.BorderRadius = 2;
            this.slotR3.CheckedState.BorderThickness = 0;
            this.slotR3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR3.CheckedState.Parent = this.slotR3;
            this.slotR3.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR3.Location = new System.Drawing.Point(108, 219);
            this.slotR3.Name = "slotR3";
            this.slotR3.Size = new System.Drawing.Size(15, 15);
            this.slotR3.TabIndex = 23;
            this.slotR3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR3.UncheckedState.BorderRadius = 2;
            this.slotR3.UncheckedState.BorderThickness = 0;
            this.slotR3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR3.UncheckedState.Parent = this.slotR3;
            // 
            // slotR2
            // 
            this.slotR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR2.Checked = true;
            this.slotR2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR2.CheckedState.BorderRadius = 2;
            this.slotR2.CheckedState.BorderThickness = 0;
            this.slotR2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR2.CheckedState.Parent = this.slotR2;
            this.slotR2.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR2.Location = new System.Drawing.Point(87, 219);
            this.slotR2.Name = "slotR2";
            this.slotR2.Size = new System.Drawing.Size(15, 15);
            this.slotR2.TabIndex = 24;
            this.slotR2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR2.UncheckedState.BorderRadius = 2;
            this.slotR2.UncheckedState.BorderThickness = 0;
            this.slotR2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR2.UncheckedState.Parent = this.slotR2;
            // 
            // slotR1
            // 
            this.slotR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.slotR1.Checked = true;
            this.slotR1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR1.CheckedState.BorderRadius = 2;
            this.slotR1.CheckedState.BorderThickness = 0;
            this.slotR1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
            this.slotR1.CheckedState.Parent = this.slotR1;
            this.slotR1.CheckMarkColor = System.Drawing.Color.Empty;
            this.slotR1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotR1.Location = new System.Drawing.Point(66, 219);
            this.slotR1.Name = "slotR1";
            this.slotR1.Size = new System.Drawing.Size(15, 15);
            this.slotR1.TabIndex = 25;
            this.slotR1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR1.UncheckedState.BorderRadius = 2;
            this.slotR1.UncheckedState.BorderThickness = 0;
            this.slotR1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.slotR1.UncheckedState.Parent = this.slotR1;
            // 
            // RightClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.slotR9);
            this.Controls.Add(this.slotR8);
            this.Controls.Add(this.slotR7);
            this.Controls.Add(this.slotR6);
            this.Controls.Add(this.slotR5);
            this.Controls.Add(this.slotR4);
            this.Controls.Add(this.slotR3);
            this.Controls.Add(this.slotR2);
            this.Controls.Add(this.slotR1);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "RightClicker";
            this.Size = new System.Drawing.Size(314, 243);
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label CpsValue;
        public Siticone.UI.WinForms.SiticoneMetroTrackBar CPSsld;
        public Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox4;
        public Siticone.UI.WinForms.SiticoneCheckBox eatBtn;
        public Siticone.UI.WinForms.SiticoneCheckBox AlwsBtn;
        public Siticone.UI.WinForms.SiticoneCheckBox BlntBtn;
        public Siticone.UI.WinForms.SiticoneCheckBox ShiftBtn;
        public Siticone.UI.WinForms.SiticoneCheckBox smrtSwitch;
        public Siticone.UI.WinForms.SiticoneButton bindbtn;
        public Siticone.UI.WinForms.SiticoneButton ToggleLClicker;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.Timer utils;
        public Siticone.UI.WinForms.SiticoneMetroTrackBar yes;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR9;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR8;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR7;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR6;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR5;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR4;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR3;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR2;
        public Siticone.UI.WinForms.SiticoneCustomCheckBox slotR1;
    }
}
