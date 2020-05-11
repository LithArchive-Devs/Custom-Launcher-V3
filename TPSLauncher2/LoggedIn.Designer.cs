namespace TPSLauncher2
{
    partial class LoggedIn
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRatio = new System.Windows.Forms.Label();
            this.txtDeaths = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.picAvi = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTracers = new System.Windows.Forms.CheckBox();
            this.cbRunLock = new System.Windows.Forms.CheckBox();
            this.cbFog = new System.Windows.Forms.CheckBox();
            this.cbvSync = new System.Windows.Forms.CheckBox();
            this.cbWindowed = new System.Windows.Forms.CheckBox();
            this.lsResolutions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabModTools = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCmdLine = new System.Windows.Forms.TextBox();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnDump = new System.Windows.Forms.Button();
            this.btnRezXtract = new System.Windows.Forms.Button();
            this.btnRezInject = new System.Windows.Forms.Button();
            this.btnDTXViewer = new System.Windows.Forms.Button();
            this.btnDTXConvert = new System.Windows.Forms.Button();
            this.btnLTB2LTA = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btn_castart = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvi)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabModTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(42, 17);
            this.Status.Text = "Status:";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 26);
            this.btnUpdate.Text = "Download/Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabModTools);
            this.tabControl1.Location = new System.Drawing.Point(0, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 148);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.panel2);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.panel1);
            this.tabMain.Controls.Add(this.picAvi);
            this.tabMain.Location = new System.Drawing.Point(4, 25);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Size = new System.Drawing.Size(603, 119);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Stats";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Launch Game";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPort);
            this.panel2.Controls.Add(this.btnLaunch);
            this.panel2.Controls.Add(this.txtIP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(249, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 98);
            this.panel2.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(39, 43);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(69, 22);
            this.txtPort.TabIndex = 6;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(117, 43);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(101, 49);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(39, 11);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(132, 22);
            this.txtIP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stats";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRatio);
            this.panel1.Controls.Add(this.txtDeaths);
            this.panel1.Controls.Add(this.txtKills);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 98);
            this.panel1.TabIndex = 4;
            // 
            // txtRatio
            // 
            this.txtRatio.AutoSize = true;
            this.txtRatio.Location = new System.Drawing.Point(11, 60);
            this.txtRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(45, 17);
            this.txtRatio.TabIndex = 2;
            this.txtRatio.Text = "Ratio:";
            // 
            // txtDeaths
            // 
            this.txtDeaths.AutoSize = true;
            this.txtDeaths.Location = new System.Drawing.Point(11, 33);
            this.txtDeaths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDeaths.Name = "txtDeaths";
            this.txtDeaths.Size = new System.Drawing.Size(50, 17);
            this.txtDeaths.TabIndex = 1;
            this.txtDeaths.Text = "Death:";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Location = new System.Drawing.Point(11, 7);
            this.txtKills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(37, 17);
            this.txtKills.TabIndex = 0;
            this.txtKills.Text = "Kills:";
            // 
            // picAvi
            // 
            this.picAvi.BackgroundImage = global::TPSLauncher2.Properties.Resources.RECORDINGS;
            this.picAvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvi.Location = new System.Drawing.Point(483, 9);
            this.picAvi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAvi.Name = "picAvi";
            this.picAvi.Size = new System.Drawing.Size(105, 98);
            this.picAvi.TabIndex = 0;
            this.picAvi.TabStop = false;
            this.picAvi.Click += new System.EventHandler(this.picAvi_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.txtBlue);
            this.tabSettings.Controls.Add(this.label9);
            this.tabSettings.Controls.Add(this.txtGreen);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.txtRed);
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Controls.Add(this.cbTracers);
            this.tabSettings.Controls.Add(this.cbRunLock);
            this.tabSettings.Controls.Add(this.cbFog);
            this.tabSettings.Controls.Add(this.cbvSync);
            this.tabSettings.Controls.Add(this.cbWindowed);
            this.tabSettings.Controls.Add(this.lsResolutions);
            this.tabSettings.Controls.Add(this.label5);
            this.tabSettings.Controls.Add(this.btnSave);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSettings.Size = new System.Drawing.Size(603, 119);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(359, 71);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(60, 22);
            this.txtBlue.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Blue:";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(359, 46);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(60, 22);
            this.txtGreen.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Green:";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(359, 18);
            this.txtRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(60, 22);
            this.txtRed.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Red:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Crosshair Color";
            // 
            // cbTracers
            // 
            this.cbTracers.AutoSize = true;
            this.cbTracers.Location = new System.Drawing.Point(169, 2);
            this.cbTracers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTracers.Name = "cbTracers";
            this.cbTracers.Size = new System.Drawing.Size(79, 21);
            this.cbTracers.TabIndex = 6;
            this.cbTracers.Text = "Tracers";
            this.cbTracers.UseVisualStyleBackColor = true;
            // 
            // cbRunLock
            // 
            this.cbRunLock.AutoSize = true;
            this.cbRunLock.Location = new System.Drawing.Point(169, 43);
            this.cbRunLock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRunLock.Name = "cbRunLock";
            this.cbRunLock.Size = new System.Drawing.Size(133, 21);
            this.cbRunLock.TabIndex = 3;
            this.cbRunLock.Text = "Always Sprinting";
            this.cbRunLock.UseVisualStyleBackColor = true;
            // 
            // cbFog
            // 
            this.cbFog.AutoSize = true;
            this.cbFog.Location = new System.Drawing.Point(169, 65);
            this.cbFog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFog.Name = "cbFog";
            this.cbFog.Size = new System.Drawing.Size(102, 21);
            this.cbFog.TabIndex = 5;
            this.cbFog.Text = "Enable Fog";
            this.cbFog.UseVisualStyleBackColor = true;
            // 
            // cbvSync
            // 
            this.cbvSync.AutoSize = true;
            this.cbvSync.Location = new System.Drawing.Point(169, 85);
            this.cbvSync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbvSync.Name = "cbvSync";
            this.cbvSync.Size = new System.Drawing.Size(68, 21);
            this.cbvSync.TabIndex = 4;
            this.cbvSync.Text = "vSync";
            this.cbvSync.UseVisualStyleBackColor = true;
            // 
            // cbWindowed
            // 
            this.cbWindowed.AutoSize = true;
            this.cbWindowed.Location = new System.Drawing.Point(169, 23);
            this.cbWindowed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbWindowed.Name = "cbWindowed";
            this.cbWindowed.Size = new System.Drawing.Size(95, 21);
            this.cbWindowed.TabIndex = 3;
            this.cbWindowed.Text = "Windowed";
            this.cbWindowed.UseVisualStyleBackColor = true;
            // 
            // lsResolutions
            // 
            this.lsResolutions.DisplayMember = "800x600x32";
            this.lsResolutions.FormattingEnabled = true;
            this.lsResolutions.ItemHeight = 16;
            this.lsResolutions.Items.AddRange(new object[] {
            "640x480x32",
            "800x600x32",
            "1024x768x32",
            "1152x864x32",
            "1280x960x32"});
            this.lsResolutions.Location = new System.Drawing.Point(4, 23);
            this.lsResolutions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsResolutions.Name = "lsResolutions";
            this.lsResolutions.Size = new System.Drawing.Size(159, 84);
            this.lsResolutions.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Game Resolution";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 84);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tabModTools
            // 
            this.tabModTools.Controls.Add(this.button1);
            this.tabModTools.Controls.Add(this.label10);
            this.tabModTools.Controls.Add(this.txtCmdLine);
            this.tabModTools.Controls.Add(this.btnTools);
            this.tabModTools.Controls.Add(this.btnDump);
            this.tabModTools.Controls.Add(this.btnRezXtract);
            this.tabModTools.Controls.Add(this.btnRezInject);
            this.tabModTools.Controls.Add(this.btnDTXViewer);
            this.tabModTools.Controls.Add(this.btnDTXConvert);
            this.tabModTools.Controls.Add(this.btnLTB2LTA);
            this.tabModTools.Location = new System.Drawing.Point(4, 25);
            this.tabModTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabModTools.Name = "tabModTools";
            this.tabModTools.Size = new System.Drawing.Size(603, 119);
            this.tabModTools.TabIndex = 2;
            this.tabModTools.Text = "Mod Tools";
            this.tabModTools.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save Cmd Lines";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Command Arguments:";
            // 
            // txtCmdLine
            // 
            this.txtCmdLine.Location = new System.Drawing.Point(343, 31);
            this.txtCmdLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCmdLine.Name = "txtCmdLine";
            this.txtCmdLine.Size = new System.Drawing.Size(241, 22);
            this.txtCmdLine.TabIndex = 14;
            // 
            // btnTools
            // 
            this.btnTools.Location = new System.Drawing.Point(235, 80);
            this.btnTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(100, 31);
            this.btnTools.TabIndex = 13;
            this.btnTools.Text = "All Tools";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(127, 80);
            this.btnDump.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(100, 31);
            this.btnDump.TabIndex = 12;
            this.btnDump.Text = "Basic Tools";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnRezXtract
            // 
            this.btnRezXtract.Location = new System.Drawing.Point(127, 42);
            this.btnRezXtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezXtract.Name = "btnRezXtract";
            this.btnRezXtract.Size = new System.Drawing.Size(100, 31);
            this.btnRezXtract.TabIndex = 11;
            this.btnRezXtract.Text = "RezXtract";
            this.btnRezXtract.UseVisualStyleBackColor = true;
            this.btnRezXtract.Click += new System.EventHandler(this.btnRezXtract_Click);
            // 
            // btnRezInject
            // 
            this.btnRezInject.Location = new System.Drawing.Point(127, 4);
            this.btnRezInject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezInject.Name = "btnRezInject";
            this.btnRezInject.Size = new System.Drawing.Size(100, 31);
            this.btnRezInject.TabIndex = 10;
            this.btnRezInject.Text = "RezInject";
            this.btnRezInject.UseVisualStyleBackColor = true;
            this.btnRezInject.Click += new System.EventHandler(this.btnRezInject_Click);
            // 
            // btnDTXViewer
            // 
            this.btnDTXViewer.Location = new System.Drawing.Point(4, 80);
            this.btnDTXViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDTXViewer.Name = "btnDTXViewer";
            this.btnDTXViewer.Size = new System.Drawing.Size(115, 31);
            this.btnDTXViewer.TabIndex = 9;
            this.btnDTXViewer.Text = "DTXViewer";
            this.btnDTXViewer.UseVisualStyleBackColor = true;
            this.btnDTXViewer.Click += new System.EventHandler(this.btnDTXViewer_Click);
            // 
            // btnDTXConvert
            // 
            this.btnDTXConvert.Location = new System.Drawing.Point(4, 42);
            this.btnDTXConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDTXConvert.Name = "btnDTXConvert";
            this.btnDTXConvert.Size = new System.Drawing.Size(115, 31);
            this.btnDTXConvert.TabIndex = 8;
            this.btnDTXConvert.Text = "DTXConvert";
            this.btnDTXConvert.UseVisualStyleBackColor = true;
            this.btnDTXConvert.Click += new System.EventHandler(this.btnDTXConvert_Click);
            // 
            // btnLTB2LTA
            // 
            this.btnLTB2LTA.Location = new System.Drawing.Point(4, 4);
            this.btnLTB2LTA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLTB2LTA.Name = "btnLTB2LTA";
            this.btnLTB2LTA.Size = new System.Drawing.Size(115, 31);
            this.btnLTB2LTA.TabIndex = 7;
            this.btnLTB2LTA.Text = "LTB2LTAGUI";
            this.btnLTB2LTA.UseVisualStyleBackColor = true;
            this.btnLTB2LTA.Click += new System.EventHandler(this.btnLTB2LTA_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::TPSLauncher2.Properties.Resources.TPS1;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(220, 4);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(371, 111);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btn_castart
            // 
            this.btn_castart.Location = new System.Drawing.Point(4, 65);
            this.btn_castart.Name = "btn_castart";
            this.btn_castart.Size = new System.Drawing.Size(75, 23);
            this.btn_castart.TabIndex = 3;
            this.btn_castart.Text = "CA Start";
            this.btn_castart.UseVisualStyleBackColor = true;
            this.btn_castart.Click += new System.EventHandler(this.btn_castart_Click);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 273);
            this.Controls.Add(this.btn_castart);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoggedIn";
            this.Text = "TPS Stats and Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvi)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabModTools.ResumeLayout(false);
            this.tabModTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.PictureBox picAvi;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtRatio;
        private System.Windows.Forms.Label txtDeaths;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.TabPage tabModTools;
        private System.Windows.Forms.Button btnLTB2LTA;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnRezXtract;
        private System.Windows.Forms.Button btnRezInject;
        private System.Windows.Forms.Button btnDTXViewer;
        private System.Windows.Forms.Button btnDTXConvert;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbTracers;
        private System.Windows.Forms.CheckBox cbRunLock;
        private System.Windows.Forms.CheckBox cbFog;
        private System.Windows.Forms.CheckBox cbvSync;
        private System.Windows.Forms.CheckBox cbWindowed;
        private System.Windows.Forms.ListBox lsResolutions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCmdLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_castart;
    }
}