namespace BSNTools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            HeaderPanel = new Panel();
            CreditsLabel = new Label();
            VersionLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BorderLabel = new Label();
            MainTabControl = new TabControl();
            tabPage1 = new TabPage();
            ConversionInfoLabel = new Label();
            OctetGroupBox = new GroupBox();
            OctetTextBox = new TextBox();
            HexGroupBox = new GroupBox();
            HexNumericUpDown = new NumericUpDown();
            BinaryGroupBox = new GroupBox();
            BinaryTextBox = new TextBox();
            DecimalGroupBox = new GroupBox();
            DecimalNumericUpDown = new NumericUpDown();
            tabPage2 = new TabPage();
            IPNetworkInfoLabel = new Label();
            TotalAddressesGroupBox = new GroupBox();
            TotalAddressesTextBox = new TextBox();
            LastUsableAddressGroupBox = new GroupBox();
            LastUsableAddressTextBox = new TextBox();
            FirstUsableAddressGroupBox = new GroupBox();
            FirstUsableAddressTextBox = new TextBox();
            UsableAddressesGroupBox = new GroupBox();
            UsableAddressesTextBox = new TextBox();
            BroadcastAddressGroupBox = new GroupBox();
            BroadcastAddressTextBox = new TextBox();
            NetworkAddressGroupBox = new GroupBox();
            NetworkAddressTextBox = new TextBox();
            SubnetmaskGroupBox = new GroupBox();
            SubnetmaskTextBox = new TextBox();
            CIDRGroupBox = new GroupBox();
            CIDRTextBox = new TextBox();
            IPAddressGroupBox = new GroupBox();
            IPAddressTextBox = new TextBox();
            IPAddressInputGroupBox = new GroupBox();
            IPAddressInputTextBox = new TextBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            OctetGroupBox.SuspendLayout();
            HexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HexNumericUpDown).BeginInit();
            BinaryGroupBox.SuspendLayout();
            DecimalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DecimalNumericUpDown).BeginInit();
            tabPage2.SuspendLayout();
            TotalAddressesGroupBox.SuspendLayout();
            LastUsableAddressGroupBox.SuspendLayout();
            FirstUsableAddressGroupBox.SuspendLayout();
            UsableAddressesGroupBox.SuspendLayout();
            BroadcastAddressGroupBox.SuspendLayout();
            NetworkAddressGroupBox.SuspendLayout();
            SubnetmaskGroupBox.SuspendLayout();
            CIDRGroupBox.SuspendLayout();
            IPAddressGroupBox.SuspendLayout();
            IPAddressInputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.Controls.Add(CreditsLabel);
            HeaderPanel.Controls.Add(VersionLabel);
            HeaderPanel.Controls.Add(label2);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Margin = new Padding(2);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(573, 54);
            HeaderPanel.TabIndex = 0;
            // 
            // CreditsLabel
            // 
            CreditsLabel.AutoSize = true;
            CreditsLabel.Location = new Point(479, 26);
            CreditsLabel.Name = "CreditsLabel";
            CreditsLabel.Size = new Size(83, 15);
            CreditsLabel.TabIndex = 4;
            CreditsLabel.Text = "by Sasha/Lynn";
            // 
            // VersionLabel
            // 
            VersionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VersionLabel.Location = new Point(430, 11);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(132, 15);
            VersionLabel.TabIndex = 3;
            VersionLabel.Text = "Version 0.0.0.1-1";
            VersionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 2;
            label2.Text = "Tools für den BSN-Unterricht";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(64, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "BSN Tools";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BSNToolsLogo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BorderLabel
            // 
            BorderLabel.BorderStyle = BorderStyle.Fixed3D;
            BorderLabel.Dock = DockStyle.Top;
            BorderLabel.Location = new Point(0, 54);
            BorderLabel.Margin = new Padding(2, 0, 2, 0);
            BorderLabel.Name = "BorderLabel";
            BorderLabel.Size = new Size(573, 1);
            BorderLabel.TabIndex = 1;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(tabPage1);
            MainTabControl.Controls.Add(tabPage2);
            MainTabControl.Location = new Point(12, 62);
            MainTabControl.Margin = new Padding(2);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(550, 345);
            MainTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ConversionInfoLabel);
            tabPage1.Controls.Add(OctetGroupBox);
            tabPage1.Controls.Add(HexGroupBox);
            tabPage1.Controls.Add(BinaryGroupBox);
            tabPage1.Controls.Add(DecimalGroupBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(542, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Umrechnung";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ConversionInfoLabel
            // 
            ConversionInfoLabel.BorderStyle = BorderStyle.Fixed3D;
            ConversionInfoLabel.Location = new Point(8, 255);
            ConversionInfoLabel.Name = "ConversionInfoLabel";
            ConversionInfoLabel.Size = new Size(527, 55);
            ConversionInfoLabel.TabIndex = 4;
            // 
            // OctetGroupBox
            // 
            OctetGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OctetGroupBox.Controls.Add(OctetTextBox);
            OctetGroupBox.Location = new Point(8, 190);
            OctetGroupBox.Margin = new Padding(2);
            OctetGroupBox.Name = "OctetGroupBox";
            OctetGroupBox.Padding = new Padding(13, 7, 13, 9);
            OctetGroupBox.Size = new Size(527, 58);
            OctetGroupBox.TabIndex = 3;
            OctetGroupBox.TabStop = false;
            OctetGroupBox.Text = "Oktett";
            OctetGroupBox.Enter += OctetGroupBox_Enter;
            OctetGroupBox.Leave += DecimalGroupBox_Leave;
            // 
            // OctetTextBox
            // 
            OctetTextBox.Dock = DockStyle.Fill;
            OctetTextBox.Location = new Point(13, 23);
            OctetTextBox.Margin = new Padding(2);
            OctetTextBox.Name = "OctetTextBox";
            OctetTextBox.Size = new Size(501, 23);
            OctetTextBox.TabIndex = 1;
            OctetTextBox.TextAlign = HorizontalAlignment.Center;
            OctetTextBox.TextChanged += OctetTextBox_TextChanged;
            // 
            // HexGroupBox
            // 
            HexGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HexGroupBox.Controls.Add(HexNumericUpDown);
            HexGroupBox.Location = new Point(8, 128);
            HexGroupBox.Margin = new Padding(2);
            HexGroupBox.Name = "HexGroupBox";
            HexGroupBox.Padding = new Padding(13, 7, 13, 9);
            HexGroupBox.Size = new Size(527, 58);
            HexGroupBox.TabIndex = 2;
            HexGroupBox.TabStop = false;
            HexGroupBox.Text = "Hexadezimal";
            HexGroupBox.Enter += HexGroupBox_Enter;
            HexGroupBox.Leave += DecimalGroupBox_Leave;
            // 
            // HexNumericUpDown
            // 
            HexNumericUpDown.Dock = DockStyle.Fill;
            HexNumericUpDown.Hexadecimal = true;
            HexNumericUpDown.Location = new Point(13, 23);
            HexNumericUpDown.Margin = new Padding(2);
            HexNumericUpDown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            HexNumericUpDown.Name = "HexNumericUpDown";
            HexNumericUpDown.Size = new Size(501, 23);
            HexNumericUpDown.TabIndex = 1;
            HexNumericUpDown.TextAlign = HorizontalAlignment.Center;
            HexNumericUpDown.ValueChanged += HexNumericUpDown_ValueChanged;
            // 
            // BinaryGroupBox
            // 
            BinaryGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BinaryGroupBox.Controls.Add(BinaryTextBox);
            BinaryGroupBox.Location = new Point(8, 66);
            BinaryGroupBox.Margin = new Padding(2);
            BinaryGroupBox.Name = "BinaryGroupBox";
            BinaryGroupBox.Padding = new Padding(13, 7, 13, 9);
            BinaryGroupBox.Size = new Size(527, 58);
            BinaryGroupBox.TabIndex = 1;
            BinaryGroupBox.TabStop = false;
            BinaryGroupBox.Text = "Binär";
            BinaryGroupBox.Enter += BinaryGroupBox_Enter;
            BinaryGroupBox.Leave += DecimalGroupBox_Leave;
            // 
            // BinaryTextBox
            // 
            BinaryTextBox.Dock = DockStyle.Fill;
            BinaryTextBox.Location = new Point(13, 23);
            BinaryTextBox.Margin = new Padding(2);
            BinaryTextBox.Name = "BinaryTextBox";
            BinaryTextBox.Size = new Size(501, 23);
            BinaryTextBox.TabIndex = 0;
            BinaryTextBox.TextAlign = HorizontalAlignment.Center;
            BinaryTextBox.TextChanged += BinaryTextBox_TextChanged;
            // 
            // DecimalGroupBox
            // 
            DecimalGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DecimalGroupBox.Controls.Add(DecimalNumericUpDown);
            DecimalGroupBox.Location = new Point(8, 5);
            DecimalGroupBox.Margin = new Padding(2);
            DecimalGroupBox.Name = "DecimalGroupBox";
            DecimalGroupBox.Padding = new Padding(13, 7, 13, 9);
            DecimalGroupBox.Size = new Size(527, 58);
            DecimalGroupBox.TabIndex = 0;
            DecimalGroupBox.TabStop = false;
            DecimalGroupBox.Text = "Dezimal";
            DecimalGroupBox.Enter += DecimalGroupBox_Enter;
            DecimalGroupBox.Leave += DecimalGroupBox_Leave;
            // 
            // DecimalNumericUpDown
            // 
            DecimalNumericUpDown.Dock = DockStyle.Fill;
            DecimalNumericUpDown.Location = new Point(13, 23);
            DecimalNumericUpDown.Margin = new Padding(2);
            DecimalNumericUpDown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            DecimalNumericUpDown.Name = "DecimalNumericUpDown";
            DecimalNumericUpDown.Size = new Size(501, 23);
            DecimalNumericUpDown.TabIndex = 0;
            DecimalNumericUpDown.TextAlign = HorizontalAlignment.Center;
            DecimalNumericUpDown.ValueChanged += DecimalNumericUpDown_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(IPNetworkInfoLabel);
            tabPage2.Controls.Add(TotalAddressesGroupBox);
            tabPage2.Controls.Add(LastUsableAddressGroupBox);
            tabPage2.Controls.Add(FirstUsableAddressGroupBox);
            tabPage2.Controls.Add(UsableAddressesGroupBox);
            tabPage2.Controls.Add(BroadcastAddressGroupBox);
            tabPage2.Controls.Add(NetworkAddressGroupBox);
            tabPage2.Controls.Add(SubnetmaskGroupBox);
            tabPage2.Controls.Add(CIDRGroupBox);
            tabPage2.Controls.Add(IPAddressGroupBox);
            tabPage2.Controls.Add(IPAddressInputGroupBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(542, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IP/Netzwerke";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // IPNetworkInfoLabel
            // 
            IPNetworkInfoLabel.AutoEllipsis = true;
            IPNetworkInfoLabel.BorderStyle = BorderStyle.Fixed3D;
            IPNetworkInfoLabel.Location = new Point(9, 267);
            IPNetworkInfoLabel.Name = "IPNetworkInfoLabel";
            IPNetworkInfoLabel.Size = new Size(526, 42);
            IPNetworkInfoLabel.TabIndex = 10;
            // 
            // TotalAddressesGroupBox
            // 
            TotalAddressesGroupBox.Controls.Add(TotalAddressesTextBox);
            TotalAddressesGroupBox.Location = new Point(363, 199);
            TotalAddressesGroupBox.Margin = new Padding(2);
            TotalAddressesGroupBox.Name = "TotalAddressesGroupBox";
            TotalAddressesGroupBox.Padding = new Padding(8, 7, 8, 2);
            TotalAddressesGroupBox.Size = new Size(172, 62);
            TotalAddressesGroupBox.TabIndex = 9;
            TotalAddressesGroupBox.TabStop = false;
            TotalAddressesGroupBox.Text = "Totale Addressen";
            TotalAddressesGroupBox.Enter += TotalAddressesGroupBox_Enter;
            // 
            // TotalAddressesTextBox
            // 
            TotalAddressesTextBox.Dock = DockStyle.Fill;
            TotalAddressesTextBox.Location = new Point(8, 23);
            TotalAddressesTextBox.Name = "TotalAddressesTextBox";
            TotalAddressesTextBox.ReadOnly = true;
            TotalAddressesTextBox.Size = new Size(156, 23);
            TotalAddressesTextBox.TabIndex = 1;
            TotalAddressesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // LastUsableAddressGroupBox
            // 
            LastUsableAddressGroupBox.Controls.Add(LastUsableAddressTextBox);
            LastUsableAddressGroupBox.Location = new Point(185, 199);
            LastUsableAddressGroupBox.Margin = new Padding(2);
            LastUsableAddressGroupBox.Name = "LastUsableAddressGroupBox";
            LastUsableAddressGroupBox.Padding = new Padding(8, 7, 8, 2);
            LastUsableAddressGroupBox.Size = new Size(172, 62);
            LastUsableAddressGroupBox.TabIndex = 8;
            LastUsableAddressGroupBox.TabStop = false;
            LastUsableAddressGroupBox.Text = "Letzte nutzbare Addresse";
            LastUsableAddressGroupBox.Enter += LastUsableAddressGroupBox_Enter;
            // 
            // LastUsableAddressTextBox
            // 
            LastUsableAddressTextBox.Dock = DockStyle.Fill;
            LastUsableAddressTextBox.Location = new Point(8, 23);
            LastUsableAddressTextBox.Name = "LastUsableAddressTextBox";
            LastUsableAddressTextBox.ReadOnly = true;
            LastUsableAddressTextBox.Size = new Size(156, 23);
            LastUsableAddressTextBox.TabIndex = 1;
            LastUsableAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FirstUsableAddressGroupBox
            // 
            FirstUsableAddressGroupBox.Controls.Add(FirstUsableAddressTextBox);
            FirstUsableAddressGroupBox.Location = new Point(9, 199);
            FirstUsableAddressGroupBox.Margin = new Padding(2);
            FirstUsableAddressGroupBox.Name = "FirstUsableAddressGroupBox";
            FirstUsableAddressGroupBox.Padding = new Padding(8, 7, 8, 2);
            FirstUsableAddressGroupBox.Size = new Size(172, 62);
            FirstUsableAddressGroupBox.TabIndex = 7;
            FirstUsableAddressGroupBox.TabStop = false;
            FirstUsableAddressGroupBox.Text = "Erste nutzbare Addresse";
            FirstUsableAddressGroupBox.Enter += FirstUsableAddressGroupBox_Enter;
            // 
            // FirstUsableAddressTextBox
            // 
            FirstUsableAddressTextBox.Dock = DockStyle.Fill;
            FirstUsableAddressTextBox.Location = new Point(8, 23);
            FirstUsableAddressTextBox.Name = "FirstUsableAddressTextBox";
            FirstUsableAddressTextBox.ReadOnly = true;
            FirstUsableAddressTextBox.Size = new Size(156, 23);
            FirstUsableAddressTextBox.TabIndex = 1;
            FirstUsableAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UsableAddressesGroupBox
            // 
            UsableAddressesGroupBox.Controls.Add(UsableAddressesTextBox);
            UsableAddressesGroupBox.Location = new Point(363, 133);
            UsableAddressesGroupBox.Margin = new Padding(2);
            UsableAddressesGroupBox.Name = "UsableAddressesGroupBox";
            UsableAddressesGroupBox.Padding = new Padding(8, 7, 8, 2);
            UsableAddressesGroupBox.Size = new Size(172, 62);
            UsableAddressesGroupBox.TabIndex = 6;
            UsableAddressesGroupBox.TabStop = false;
            UsableAddressesGroupBox.Text = "Nutzbare Addressen";
            UsableAddressesGroupBox.Enter += UsableAddressesGroupBox_Enter;
            // 
            // UsableAddressesTextBox
            // 
            UsableAddressesTextBox.Dock = DockStyle.Fill;
            UsableAddressesTextBox.Location = new Point(8, 23);
            UsableAddressesTextBox.Name = "UsableAddressesTextBox";
            UsableAddressesTextBox.ReadOnly = true;
            UsableAddressesTextBox.Size = new Size(156, 23);
            UsableAddressesTextBox.TabIndex = 1;
            UsableAddressesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BroadcastAddressGroupBox
            // 
            BroadcastAddressGroupBox.Controls.Add(BroadcastAddressTextBox);
            BroadcastAddressGroupBox.Location = new Point(185, 133);
            BroadcastAddressGroupBox.Margin = new Padding(2);
            BroadcastAddressGroupBox.Name = "BroadcastAddressGroupBox";
            BroadcastAddressGroupBox.Padding = new Padding(8, 7, 8, 2);
            BroadcastAddressGroupBox.Size = new Size(172, 62);
            BroadcastAddressGroupBox.TabIndex = 5;
            BroadcastAddressGroupBox.TabStop = false;
            BroadcastAddressGroupBox.Text = "Broadcastaddresse";
            BroadcastAddressGroupBox.Enter += BroadcastAddressGroupBox_Enter;
            // 
            // BroadcastAddressTextBox
            // 
            BroadcastAddressTextBox.Dock = DockStyle.Fill;
            BroadcastAddressTextBox.Location = new Point(8, 23);
            BroadcastAddressTextBox.Name = "BroadcastAddressTextBox";
            BroadcastAddressTextBox.ReadOnly = true;
            BroadcastAddressTextBox.Size = new Size(156, 23);
            BroadcastAddressTextBox.TabIndex = 1;
            BroadcastAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NetworkAddressGroupBox
            // 
            NetworkAddressGroupBox.Controls.Add(NetworkAddressTextBox);
            NetworkAddressGroupBox.Location = new Point(9, 133);
            NetworkAddressGroupBox.Margin = new Padding(2);
            NetworkAddressGroupBox.Name = "NetworkAddressGroupBox";
            NetworkAddressGroupBox.Padding = new Padding(8, 7, 8, 2);
            NetworkAddressGroupBox.Size = new Size(172, 62);
            NetworkAddressGroupBox.TabIndex = 4;
            NetworkAddressGroupBox.TabStop = false;
            NetworkAddressGroupBox.Text = "Netzwerkaddresse";
            NetworkAddressGroupBox.Enter += NetworkAddressGroupBox_Enter;
            // 
            // NetworkAddressTextBox
            // 
            NetworkAddressTextBox.Dock = DockStyle.Fill;
            NetworkAddressTextBox.Location = new Point(8, 23);
            NetworkAddressTextBox.Name = "NetworkAddressTextBox";
            NetworkAddressTextBox.ReadOnly = true;
            NetworkAddressTextBox.Size = new Size(156, 23);
            NetworkAddressTextBox.TabIndex = 1;
            NetworkAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SubnetmaskGroupBox
            // 
            SubnetmaskGroupBox.Controls.Add(SubnetmaskTextBox);
            SubnetmaskGroupBox.Location = new Point(363, 67);
            SubnetmaskGroupBox.Margin = new Padding(2);
            SubnetmaskGroupBox.Name = "SubnetmaskGroupBox";
            SubnetmaskGroupBox.Padding = new Padding(8, 7, 8, 2);
            SubnetmaskGroupBox.Size = new Size(172, 62);
            SubnetmaskGroupBox.TabIndex = 3;
            SubnetmaskGroupBox.TabStop = false;
            SubnetmaskGroupBox.Text = "Subnetzmaske";
            SubnetmaskGroupBox.Enter += SubnetmaskGroupBox_Enter;
            // 
            // SubnetmaskTextBox
            // 
            SubnetmaskTextBox.Dock = DockStyle.Fill;
            SubnetmaskTextBox.Location = new Point(8, 23);
            SubnetmaskTextBox.Name = "SubnetmaskTextBox";
            SubnetmaskTextBox.ReadOnly = true;
            SubnetmaskTextBox.Size = new Size(156, 23);
            SubnetmaskTextBox.TabIndex = 1;
            SubnetmaskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CIDRGroupBox
            // 
            CIDRGroupBox.Controls.Add(CIDRTextBox);
            CIDRGroupBox.Location = new Point(185, 67);
            CIDRGroupBox.Margin = new Padding(2);
            CIDRGroupBox.Name = "CIDRGroupBox";
            CIDRGroupBox.Padding = new Padding(8, 7, 8, 2);
            CIDRGroupBox.Size = new Size(172, 62);
            CIDRGroupBox.TabIndex = 2;
            CIDRGroupBox.TabStop = false;
            CIDRGroupBox.Text = "CIDR";
            CIDRGroupBox.Enter += CIDRGroupBox_Enter;
            // 
            // CIDRTextBox
            // 
            CIDRTextBox.Dock = DockStyle.Fill;
            CIDRTextBox.Location = new Point(8, 23);
            CIDRTextBox.Name = "CIDRTextBox";
            CIDRTextBox.ReadOnly = true;
            CIDRTextBox.Size = new Size(156, 23);
            CIDRTextBox.TabIndex = 1;
            CIDRTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // IPAddressGroupBox
            // 
            IPAddressGroupBox.Controls.Add(IPAddressTextBox);
            IPAddressGroupBox.Location = new Point(9, 67);
            IPAddressGroupBox.Margin = new Padding(2);
            IPAddressGroupBox.Name = "IPAddressGroupBox";
            IPAddressGroupBox.Padding = new Padding(8, 7, 8, 2);
            IPAddressGroupBox.Size = new Size(172, 62);
            IPAddressGroupBox.TabIndex = 1;
            IPAddressGroupBox.TabStop = false;
            IPAddressGroupBox.Text = "IP-Addresse";
            IPAddressGroupBox.Enter += IPAddressGroupBox_Enter;
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Dock = DockStyle.Fill;
            IPAddressTextBox.Location = new Point(8, 23);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.ReadOnly = true;
            IPAddressTextBox.Size = new Size(156, 23);
            IPAddressTextBox.TabIndex = 0;
            IPAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // IPAddressInputGroupBox
            // 
            IPAddressInputGroupBox.Controls.Add(IPAddressInputTextBox);
            IPAddressInputGroupBox.Location = new Point(8, 5);
            IPAddressInputGroupBox.Margin = new Padding(2);
            IPAddressInputGroupBox.Name = "IPAddressInputGroupBox";
            IPAddressInputGroupBox.Padding = new Padding(13, 7, 13, 9);
            IPAddressInputGroupBox.Size = new Size(527, 58);
            IPAddressInputGroupBox.TabIndex = 0;
            IPAddressInputGroupBox.TabStop = false;
            IPAddressInputGroupBox.Text = "IP-Addresse/CIDR";
            IPAddressInputGroupBox.Enter += IPAddressInputGroupBox_Enter;
            // 
            // IPAddressInputTextBox
            // 
            IPAddressInputTextBox.Dock = DockStyle.Fill;
            IPAddressInputTextBox.Location = new Point(13, 23);
            IPAddressInputTextBox.Margin = new Padding(2);
            IPAddressInputTextBox.Name = "IPAddressInputTextBox";
            IPAddressInputTextBox.Size = new Size(501, 23);
            IPAddressInputTextBox.TabIndex = 0;
            IPAddressInputTextBox.TextAlign = HorizontalAlignment.Center;
            IPAddressInputTextBox.TextChanged += IPAddressInputTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 416);
            Controls.Add(MainTabControl);
            Controls.Add(BorderLabel);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "BSN Tools";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            OctetGroupBox.ResumeLayout(false);
            OctetGroupBox.PerformLayout();
            HexGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HexNumericUpDown).EndInit();
            BinaryGroupBox.ResumeLayout(false);
            BinaryGroupBox.PerformLayout();
            DecimalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DecimalNumericUpDown).EndInit();
            tabPage2.ResumeLayout(false);
            TotalAddressesGroupBox.ResumeLayout(false);
            TotalAddressesGroupBox.PerformLayout();
            LastUsableAddressGroupBox.ResumeLayout(false);
            LastUsableAddressGroupBox.PerformLayout();
            FirstUsableAddressGroupBox.ResumeLayout(false);
            FirstUsableAddressGroupBox.PerformLayout();
            UsableAddressesGroupBox.ResumeLayout(false);
            UsableAddressesGroupBox.PerformLayout();
            BroadcastAddressGroupBox.ResumeLayout(false);
            BroadcastAddressGroupBox.PerformLayout();
            NetworkAddressGroupBox.ResumeLayout(false);
            NetworkAddressGroupBox.PerformLayout();
            SubnetmaskGroupBox.ResumeLayout(false);
            SubnetmaskGroupBox.PerformLayout();
            CIDRGroupBox.ResumeLayout(false);
            CIDRGroupBox.PerformLayout();
            IPAddressGroupBox.ResumeLayout(false);
            IPAddressGroupBox.PerformLayout();
            IPAddressInputGroupBox.ResumeLayout(false);
            IPAddressInputGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label BorderLabel;
        private PictureBox pictureBox1;
        private TabControl MainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private GroupBox OctetGroupBox;
        private GroupBox HexGroupBox;
        private GroupBox BinaryGroupBox;
        private GroupBox DecimalGroupBox;
        private TextBox OctetTextBox;
        private NumericUpDown HexNumericUpDown;
        private TextBox BinaryTextBox;
        private NumericUpDown DecimalNumericUpDown;
        private GroupBox IPAddressInputGroupBox;
        private TextBox IPAddressInputTextBox;
        private GroupBox SubnetmaskGroupBox;
        private GroupBox CIDRGroupBox;
        private GroupBox IPAddressGroupBox;
        private GroupBox TotalAddressesGroupBox;
        private GroupBox LastUsableAddressGroupBox;
        private GroupBox FirstUsableAddressGroupBox;
        private GroupBox UsableAddressesGroupBox;
        private GroupBox BroadcastAddressGroupBox;
        private GroupBox NetworkAddressGroupBox;
        private TextBox IPAddressTextBox;
        private TextBox TotalAddressesTextBox;
        private TextBox LastUsableAddressTextBox;
        private TextBox FirstUsableAddressTextBox;
        private TextBox UsableAddressesTextBox;
        private TextBox BroadcastAddressTextBox;
        private TextBox NetworkAddressTextBox;
        private TextBox SubnetmaskTextBox;
        private TextBox CIDRTextBox;
        private Label ConversionInfoLabel;
        private Label IPNetworkInfoLabel;
        private Label VersionLabel;
        private Label CreditsLabel;
    }
}
