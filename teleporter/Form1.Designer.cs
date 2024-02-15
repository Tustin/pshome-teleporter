namespace teleporter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.nsTheme1 = new NSTheme();
            this.cc = new NSRadioButton();
            this.tm = new NSRadioButton();
            this.nsComboBox1 = new NSComboBox();
            this.slow = new NSCheckBox();
            this.jetpack = new NSCheckBox();
            this.auto = new NSCheckBox();
            this.zbox = new System.Windows.Forms.NumericUpDown();
            this.ybox = new System.Windows.Forms.NumericUpDown();
            this.xbox = new System.Windows.Forms.NumericUpDown();
            this.nsButton4 = new NSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nsControlButton1 = new NSControlButton();
            this.getcoords = new NSButton();
            this.teleport = new NSButton();
            this.establish = new NSButton();
            this.nsTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.cc);
            this.nsTheme1.Controls.Add(this.tm);
            this.nsTheme1.Controls.Add(this.nsComboBox1);
            this.nsTheme1.Controls.Add(this.slow);
            this.nsTheme1.Controls.Add(this.jetpack);
            this.nsTheme1.Controls.Add(this.auto);
            this.nsTheme1.Controls.Add(this.zbox);
            this.nsTheme1.Controls.Add(this.ybox);
            this.nsTheme1.Controls.Add(this.xbox);
            this.nsTheme1.Controls.Add(this.nsButton4);
            this.nsTheme1.Controls.Add(this.label1);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.getcoords);
            this.nsTheme1.Controls.Add(this.teleport);
            this.nsTheme1.Controls.Add(this.establish);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = true;
            this.nsTheme1.Size = new System.Drawing.Size(354, 185);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "PSHomeCentral Teleporter";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // cc
            // 
            this.cc.Checked = false;
            this.cc.Location = new System.Drawing.Point(194, 35);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(75, 23);
            this.cc.TabIndex = 21;
            this.cc.Text = "CCAPI";
            // 
            // tm
            // 
            this.tm.Checked = false;
            this.tm.Location = new System.Drawing.Point(124, 35);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(75, 23);
            this.tm.TabIndex = 20;
            this.tm.Text = "TMAPI";
            // 
            // nsComboBox1
            // 
            this.nsComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nsComboBox1.ForeColor = System.Drawing.Color.White;
            this.nsComboBox1.FormattingEnabled = true;
            this.nsComboBox1.Location = new System.Drawing.Point(0, 113);
            this.nsComboBox1.Name = "nsComboBox1";
            this.nsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.nsComboBox1.TabIndex = 19;
            this.nsComboBox1.Visible = false;
            // 
            // slow
            // 
            this.slow.Checked = false;
            this.slow.Enabled = false;
            this.slow.Location = new System.Drawing.Point(252, 159);
            this.slow.Name = "slow";
            this.slow.Size = new System.Drawing.Size(97, 23);
            this.slow.TabIndex = 18;
            this.slow.Text = "Slow Jetpack";
            this.slow.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged_2);
            // 
            // jetpack
            // 
            this.jetpack.Checked = false;
            this.jetpack.Enabled = false;
            this.jetpack.Location = new System.Drawing.Point(252, 130);
            this.jetpack.Name = "jetpack";
            this.jetpack.Size = new System.Drawing.Size(70, 23);
            this.jetpack.TabIndex = 17;
            this.jetpack.Text = "Jetpack";
            this.jetpack.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged_1);
            // 
            // auto
            // 
            this.auto.Checked = false;
            this.auto.Enabled = false;
            this.auto.Location = new System.Drawing.Point(6, 158);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(97, 23);
            this.auto.TabIndex = 15;
            this.auto.Text = "Auto Update";
            this.auto.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged);
            // 
            // zbox
            // 
            this.zbox.DecimalPlaces = 6;
            this.zbox.Enabled = false;
            this.zbox.Location = new System.Drawing.Point(261, 75);
            this.zbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.zbox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.zbox.Name = "zbox";
            this.zbox.Size = new System.Drawing.Size(81, 20);
            this.zbox.TabIndex = 14;
            // 
            // ybox
            // 
            this.ybox.DecimalPlaces = 6;
            this.ybox.Enabled = false;
            this.ybox.Location = new System.Drawing.Point(137, 75);
            this.ybox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ybox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(81, 20);
            this.ybox.TabIndex = 13;
            // 
            // xbox
            // 
            this.xbox.DecimalPlaces = 6;
            this.xbox.Enabled = false;
            this.xbox.Location = new System.Drawing.Point(12, 75);
            this.xbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xbox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(81, 20);
            this.xbox.TabIndex = 12;
            this.xbox.ValueChanged += new System.EventHandler(this.xbox_ValueChanged);
            // 
            // nsButton4
            // 
            this.nsButton4.Location = new System.Drawing.Point(137, 158);
            this.nsButton4.Name = "nsButton4";
            this.nsButton4.Size = new System.Drawing.Size(67, 23);
            this.nsButton4.TabIndex = 11;
            this.nsButton4.Text = "Save Loc";
            this.nsButton4.Visible = false;
            this.nsButton4.Click += new System.EventHandler(this.nsButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Visible = false;
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(331, 2);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 9;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // getcoords
            // 
            this.getcoords.Enabled = false;
            this.getcoords.Location = new System.Drawing.Point(12, 35);
            this.getcoords.Name = "getcoords";
            this.getcoords.Size = new System.Drawing.Size(81, 23);
            this.getcoords.TabIndex = 8;
            this.getcoords.Text = "Get Coords";
            this.getcoords.Click += new System.EventHandler(this.nsButton3_Click);
            // 
            // teleport
            // 
            this.teleport.Enabled = false;
            this.teleport.Location = new System.Drawing.Point(134, 106);
            this.teleport.Name = "teleport";
            this.teleport.Size = new System.Drawing.Size(84, 23);
            this.teleport.TabIndex = 4;
            this.teleport.Text = "  Teleport!";
            this.teleport.Click += new System.EventHandler(this.nsButton2_Click);
            // 
            // establish
            // 
            this.establish.Location = new System.Drawing.Point(275, 35);
            this.establish.Name = "establish";
            this.establish.Size = new System.Drawing.Size(69, 23);
            this.establish.TabIndex = 0;
            this.establish.Text = "Establish";
            this.establish.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 185);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ybox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSButton establish;
        private NSButton teleport;
        private NSButton getcoords;
        private NSControlButton nsControlButton1;
        private System.Windows.Forms.Label label1;
        private NSButton nsButton4;
        private System.Windows.Forms.NumericUpDown zbox;
        private System.Windows.Forms.NumericUpDown ybox;
        private System.Windows.Forms.NumericUpDown xbox;
        private NSCheckBox auto;
        private System.Windows.Forms.Timer timer1;
        private NSCheckBox jetpack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private NSCheckBox slow;
        private System.Windows.Forms.Timer timer3;
        private NSComboBox nsComboBox1;
        private NSRadioButton cc;
        private NSRadioButton tm;
    }
}

