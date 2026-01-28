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
            StartTabPage = new TabPage();
            NumericSystemConversionsTabPage = new TabPage();
            IPv4NetworkTabPage = new TabPage();
            IPCalculationToolsSplitContainer = new SplitContainer();
            IPCalculationInfosTableLayoutPanel = new TableLayoutPanel();
            IPBroadcastAddressLabel = new Label();
            IPNetworkAddressLabel = new Label();
            IPAddressCIDRLabel = new Label();
            IPNetmaskLabel = new Label();
            IPFirstAddressLabel = new Label();
            IPFirstUsableAddressLabel = new Label();
            IPTotalsLabel = new Label();
            IPLastUsableAddressLabel = new Label();
            IPLastAddressLabel = new Label();
            UnitConversionTabPage = new TabPage();
            AboutTabPage = new TabPage();
            DebugTabPage = new TabPage();
            LogRichTextBox = new RichTextBox();
            IPAddressCIDRTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPNetmaskTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPNetworkAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPBroadcastAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPFirstAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPFirstUsableAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPLastAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPLastUsableAddressTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            IPTotalsTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainTabControl.SuspendLayout();
            IPv4NetworkTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).BeginInit();
            IPCalculationToolsSplitContainer.Panel1.SuspendLayout();
            IPCalculationToolsSplitContainer.SuspendLayout();
            IPCalculationInfosTableLayoutPanel.SuspendLayout();
            DebugTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IPAddressCIDRTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPNetmaskTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPNetworkAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPBroadcastAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPFirstAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPFirstUsableAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPLastAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPLastUsableAddressTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IPTotalsTextBoxExt).BeginInit();
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
            HeaderPanel.Size = new Size(720, 54);
            HeaderPanel.TabIndex = 0;
            // 
            // CreditsLabel
            // 
            CreditsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreditsLabel.AutoSize = true;
            CreditsLabel.Location = new Point(626, 26);
            CreditsLabel.Name = "CreditsLabel";
            CreditsLabel.Size = new Size(83, 15);
            CreditsLabel.TabIndex = 4;
            CreditsLabel.Text = "by Sasha/Lynn";
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VersionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VersionLabel.Location = new Point(516, 11);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(193, 15);
            VersionLabel.TabIndex = 3;
            VersionLabel.Text = "Version %Version%";
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
            BorderLabel.Size = new Size(720, 1);
            BorderLabel.TabIndex = 1;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(StartTabPage);
            MainTabControl.Controls.Add(NumericSystemConversionsTabPage);
            MainTabControl.Controls.Add(IPv4NetworkTabPage);
            MainTabControl.Controls.Add(UnitConversionTabPage);
            MainTabControl.Controls.Add(AboutTabPage);
            MainTabControl.Controls.Add(DebugTabPage);
            MainTabControl.Location = new Point(12, 62);
            MainTabControl.Margin = new Padding(2);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(697, 460);
            MainTabControl.TabIndex = 2;
            // 
            // StartTabPage
            // 
            StartTabPage.Location = new Point(4, 24);
            StartTabPage.Name = "StartTabPage";
            StartTabPage.Padding = new Padding(3);
            StartTabPage.Size = new Size(689, 432);
            StartTabPage.TabIndex = 2;
            StartTabPage.Text = "Start";
            StartTabPage.UseVisualStyleBackColor = true;
            // 
            // NumericSystemConversionsTabPage
            // 
            NumericSystemConversionsTabPage.Location = new Point(4, 24);
            NumericSystemConversionsTabPage.Margin = new Padding(2);
            NumericSystemConversionsTabPage.Name = "NumericSystemConversionsTabPage";
            NumericSystemConversionsTabPage.Padding = new Padding(2);
            NumericSystemConversionsTabPage.Size = new Size(689, 432);
            NumericSystemConversionsTabPage.TabIndex = 0;
            NumericSystemConversionsTabPage.Text = "Umrechnung";
            NumericSystemConversionsTabPage.UseVisualStyleBackColor = true;
            // 
            // IPv4NetworkTabPage
            // 
            IPv4NetworkTabPage.Controls.Add(IPCalculationToolsSplitContainer);
            IPv4NetworkTabPage.Location = new Point(4, 24);
            IPv4NetworkTabPage.Margin = new Padding(2);
            IPv4NetworkTabPage.Name = "IPv4NetworkTabPage";
            IPv4NetworkTabPage.Padding = new Padding(2);
            IPv4NetworkTabPage.Size = new Size(689, 432);
            IPv4NetworkTabPage.TabIndex = 1;
            IPv4NetworkTabPage.Text = "IP/Netzwerke";
            IPv4NetworkTabPage.UseVisualStyleBackColor = true;
            // 
            // IPCalculationToolsSplitContainer
            // 
            IPCalculationToolsSplitContainer.BorderStyle = BorderStyle.Fixed3D;
            IPCalculationToolsSplitContainer.Location = new Point(20, 84);
            IPCalculationToolsSplitContainer.Name = "IPCalculationToolsSplitContainer";
            // 
            // IPCalculationToolsSplitContainer.Panel1
            // 
            IPCalculationToolsSplitContainer.Panel1.Controls.Add(IPCalculationInfosTableLayoutPanel);
            IPCalculationToolsSplitContainer.Size = new Size(648, 332);
            IPCalculationToolsSplitContainer.SplitterDistance = 452;
            IPCalculationToolsSplitContainer.TabIndex = 1;
            // 
            // IPCalculationInfosTableLayoutPanel
            // 
            IPCalculationInfosTableLayoutPanel.ColumnCount = 2;
            IPCalculationInfosTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            IPCalculationInfosTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPTotalsTextBoxExt, 1, 8);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPLastUsableAddressTextBoxExt, 1, 7);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPLastAddressTextBoxExt, 1, 6);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPFirstUsableAddressTextBoxExt, 1, 5);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPFirstAddressTextBoxExt, 1, 4);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPBroadcastAddressTextBoxExt, 1, 3);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPNetworkAddressTextBoxExt, 1, 2);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPNetmaskTextBoxExt, 1, 1);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPBroadcastAddressLabel, 0, 3);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPNetworkAddressLabel, 0, 2);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPAddressCIDRLabel, 0, 0);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPNetmaskLabel, 0, 1);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPFirstAddressLabel, 0, 4);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPFirstUsableAddressLabel, 0, 5);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPTotalsLabel, 0, 8);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPLastUsableAddressLabel, 0, 7);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPLastAddressLabel, 0, 6);
            IPCalculationInfosTableLayoutPanel.Controls.Add(IPAddressCIDRTextBoxExt, 1, 0);
            IPCalculationInfosTableLayoutPanel.Dock = DockStyle.Fill;
            IPCalculationInfosTableLayoutPanel.Location = new Point(0, 0);
            IPCalculationInfosTableLayoutPanel.Name = "IPCalculationInfosTableLayoutPanel";
            IPCalculationInfosTableLayoutPanel.RowCount = 10;
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            IPCalculationInfosTableLayoutPanel.Size = new Size(448, 328);
            IPCalculationInfosTableLayoutPanel.TabIndex = 0;
            // 
            // IPBroadcastAddressLabel
            // 
            IPBroadcastAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPBroadcastAddressLabel.AutoSize = true;
            IPBroadcastAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPBroadcastAddressLabel.Location = new Point(3, 96);
            IPBroadcastAddressLabel.Name = "IPBroadcastAddressLabel";
            IPBroadcastAddressLabel.Size = new Size(133, 32);
            IPBroadcastAddressLabel.TabIndex = 6;
            IPBroadcastAddressLabel.Text = "Broadcast-Adresse:";
            IPBroadcastAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPNetworkAddressLabel
            // 
            IPNetworkAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPNetworkAddressLabel.AutoSize = true;
            IPNetworkAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPNetworkAddressLabel.Location = new Point(3, 64);
            IPNetworkAddressLabel.Name = "IPNetworkAddressLabel";
            IPNetworkAddressLabel.Size = new Size(126, 32);
            IPNetworkAddressLabel.TabIndex = 4;
            IPNetworkAddressLabel.Text = "Netzwerk-Adresse:";
            IPNetworkAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPAddressCIDRLabel
            // 
            IPAddressCIDRLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPAddressCIDRLabel.AutoSize = true;
            IPAddressCIDRLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPAddressCIDRLabel.Location = new Point(3, 0);
            IPAddressCIDRLabel.Name = "IPAddressCIDRLabel";
            IPAddressCIDRLabel.Size = new Size(119, 32);
            IPAddressCIDRLabel.TabIndex = 0;
            IPAddressCIDRLabel.Text = "IP-Adresse/CIDR:";
            IPAddressCIDRLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPNetmaskLabel
            // 
            IPNetmaskLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPNetmaskLabel.AutoSize = true;
            IPNetmaskLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPNetmaskLabel.Location = new Point(3, 32);
            IPNetmaskLabel.Name = "IPNetmaskLabel";
            IPNetmaskLabel.Size = new Size(77, 32);
            IPNetmaskLabel.TabIndex = 1;
            IPNetmaskLabel.Text = "Netzmaske:";
            IPNetmaskLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPFirstAddressLabel
            // 
            IPFirstAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPFirstAddressLabel.AutoSize = true;
            IPFirstAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPFirstAddressLabel.Location = new Point(3, 128);
            IPFirstAddressLabel.Name = "IPFirstAddressLabel";
            IPFirstAddressLabel.Size = new Size(105, 32);
            IPFirstAddressLabel.TabIndex = 5;
            IPFirstAddressLabel.Text = "Erste Adresse:";
            IPFirstAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPFirstUsableAddressLabel
            // 
            IPFirstUsableAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPFirstUsableAddressLabel.AutoSize = true;
            IPFirstUsableAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPFirstUsableAddressLabel.Location = new Point(3, 160);
            IPFirstUsableAddressLabel.Name = "IPFirstUsableAddressLabel";
            IPFirstUsableAddressLabel.Size = new Size(168, 32);
            IPFirstUsableAddressLabel.TabIndex = 8;
            IPFirstUsableAddressLabel.Text = "Erste nutzbare Adresse:";
            IPFirstUsableAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPTotalsLabel
            // 
            IPTotalsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPTotalsLabel.AutoSize = true;
            IPTotalsLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPTotalsLabel.Location = new Point(3, 256);
            IPTotalsLabel.Name = "IPTotalsLabel";
            IPTotalsLabel.Size = new Size(182, 32);
            IPTotalsLabel.TabIndex = 2;
            IPTotalsLabel.Text = "Anzahl / Anzahl Nutzbare:";
            IPTotalsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPLastUsableAddressLabel
            // 
            IPLastUsableAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPLastUsableAddressLabel.AutoSize = true;
            IPLastUsableAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPLastUsableAddressLabel.Location = new Point(3, 224);
            IPLastUsableAddressLabel.Name = "IPLastUsableAddressLabel";
            IPLastUsableAddressLabel.Size = new Size(175, 32);
            IPLastUsableAddressLabel.TabIndex = 7;
            IPLastUsableAddressLabel.Text = "Letzte nutzbare Adresse:";
            IPLastUsableAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IPLastAddressLabel
            // 
            IPLastAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IPLastAddressLabel.AutoSize = true;
            IPLastAddressLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPLastAddressLabel.Location = new Point(3, 192);
            IPLastAddressLabel.Name = "IPLastAddressLabel";
            IPLastAddressLabel.Size = new Size(112, 32);
            IPLastAddressLabel.TabIndex = 3;
            IPLastAddressLabel.Text = "Letzte Adresse:";
            IPLastAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UnitConversionTabPage
            // 
            UnitConversionTabPage.Location = new Point(4, 24);
            UnitConversionTabPage.Name = "UnitConversionTabPage";
            UnitConversionTabPage.Padding = new Padding(3);
            UnitConversionTabPage.Size = new Size(689, 432);
            UnitConversionTabPage.TabIndex = 3;
            UnitConversionTabPage.Text = "Konversion";
            UnitConversionTabPage.UseVisualStyleBackColor = true;
            // 
            // AboutTabPage
            // 
            AboutTabPage.Location = new Point(4, 24);
            AboutTabPage.Name = "AboutTabPage";
            AboutTabPage.Padding = new Padding(3);
            AboutTabPage.Size = new Size(689, 432);
            AboutTabPage.TabIndex = 4;
            AboutTabPage.Text = "Über das Programm";
            AboutTabPage.UseVisualStyleBackColor = true;
            // 
            // DebugTabPage
            // 
            DebugTabPage.Controls.Add(LogRichTextBox);
            DebugTabPage.Location = new Point(4, 24);
            DebugTabPage.Name = "DebugTabPage";
            DebugTabPage.Padding = new Padding(3);
            DebugTabPage.Size = new Size(689, 432);
            DebugTabPage.TabIndex = 6;
            DebugTabPage.Text = "Log";
            DebugTabPage.UseVisualStyleBackColor = true;
            // 
            // LogRichTextBox
            // 
            LogRichTextBox.Dock = DockStyle.Fill;
            LogRichTextBox.Location = new Point(3, 3);
            LogRichTextBox.Name = "LogRichTextBox";
            LogRichTextBox.ReadOnly = true;
            LogRichTextBox.Size = new Size(683, 426);
            LogRichTextBox.TabIndex = 0;
            LogRichTextBox.Text = "";
            // 
            // IPAddressCIDRTextBoxExt
            // 
            IPAddressCIDRTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPAddressCIDRTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPAddressCIDRTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPAddressCIDRTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPAddressCIDRTextBoxExt.Font = new Font("Consolas", 9F);
            IPAddressCIDRTextBoxExt.Location = new Point(191, 4);
            IPAddressCIDRTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPAddressCIDRTextBoxExt.Name = "IPAddressCIDRTextBoxExt";
            IPAddressCIDRTextBoxExt.ReadOnly = true;
            IPAddressCIDRTextBoxExt.Size = new Size(254, 22);
            IPAddressCIDRTextBoxExt.TabIndex = 9;
            IPAddressCIDRTextBoxExt.ThemeName = "Default";
            IPAddressCIDRTextBoxExt.ThemesEnabled = false;
            // 
            // IPNetmaskTextBoxExt
            // 
            IPNetmaskTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPNetmaskTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPNetmaskTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPNetmaskTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPNetmaskTextBoxExt.Font = new Font("Consolas", 9F);
            IPNetmaskTextBoxExt.Location = new Point(191, 36);
            IPNetmaskTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPNetmaskTextBoxExt.Name = "IPNetmaskTextBoxExt";
            IPNetmaskTextBoxExt.ReadOnly = true;
            IPNetmaskTextBoxExt.Size = new Size(254, 22);
            IPNetmaskTextBoxExt.TabIndex = 10;
            IPNetmaskTextBoxExt.ThemeName = "Default";
            IPNetmaskTextBoxExt.ThemesEnabled = false;
            // 
            // IPNetworkAddressTextBoxExt
            // 
            IPNetworkAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPNetworkAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPNetworkAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPNetworkAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPNetworkAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPNetworkAddressTextBoxExt.Location = new Point(191, 68);
            IPNetworkAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPNetworkAddressTextBoxExt.Name = "IPNetworkAddressTextBoxExt";
            IPNetworkAddressTextBoxExt.ReadOnly = true;
            IPNetworkAddressTextBoxExt.Size = new Size(254, 22);
            IPNetworkAddressTextBoxExt.TabIndex = 11;
            IPNetworkAddressTextBoxExt.ThemeName = "Default";
            IPNetworkAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPBroadcastAddressTextBoxExt
            // 
            IPBroadcastAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPBroadcastAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPBroadcastAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPBroadcastAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPBroadcastAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPBroadcastAddressTextBoxExt.Location = new Point(191, 100);
            IPBroadcastAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPBroadcastAddressTextBoxExt.Name = "IPBroadcastAddressTextBoxExt";
            IPBroadcastAddressTextBoxExt.ReadOnly = true;
            IPBroadcastAddressTextBoxExt.Size = new Size(254, 22);
            IPBroadcastAddressTextBoxExt.TabIndex = 12;
            IPBroadcastAddressTextBoxExt.ThemeName = "Default";
            IPBroadcastAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPFirstAddressTextBoxExt
            // 
            IPFirstAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPFirstAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPFirstAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPFirstAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPFirstAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPFirstAddressTextBoxExt.Location = new Point(191, 132);
            IPFirstAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPFirstAddressTextBoxExt.Name = "IPFirstAddressTextBoxExt";
            IPFirstAddressTextBoxExt.ReadOnly = true;
            IPFirstAddressTextBoxExt.Size = new Size(254, 22);
            IPFirstAddressTextBoxExt.TabIndex = 13;
            IPFirstAddressTextBoxExt.ThemeName = "Default";
            IPFirstAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPFirstUsableAddressTextBoxExt
            // 
            IPFirstUsableAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPFirstUsableAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPFirstUsableAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPFirstUsableAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPFirstUsableAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPFirstUsableAddressTextBoxExt.Location = new Point(191, 164);
            IPFirstUsableAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPFirstUsableAddressTextBoxExt.Name = "IPFirstUsableAddressTextBoxExt";
            IPFirstUsableAddressTextBoxExt.ReadOnly = true;
            IPFirstUsableAddressTextBoxExt.Size = new Size(254, 22);
            IPFirstUsableAddressTextBoxExt.TabIndex = 14;
            IPFirstUsableAddressTextBoxExt.ThemeName = "Default";
            IPFirstUsableAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPLastAddressTextBoxExt
            // 
            IPLastAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPLastAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPLastAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPLastAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPLastAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPLastAddressTextBoxExt.Location = new Point(191, 196);
            IPLastAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPLastAddressTextBoxExt.Name = "IPLastAddressTextBoxExt";
            IPLastAddressTextBoxExt.ReadOnly = true;
            IPLastAddressTextBoxExt.Size = new Size(254, 22);
            IPLastAddressTextBoxExt.TabIndex = 15;
            IPLastAddressTextBoxExt.ThemeName = "Default";
            IPLastAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPLastUsableAddressTextBoxExt
            // 
            IPLastUsableAddressTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPLastUsableAddressTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPLastUsableAddressTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPLastUsableAddressTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPLastUsableAddressTextBoxExt.Font = new Font("Consolas", 9F);
            IPLastUsableAddressTextBoxExt.Location = new Point(191, 228);
            IPLastUsableAddressTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPLastUsableAddressTextBoxExt.Name = "IPLastUsableAddressTextBoxExt";
            IPLastUsableAddressTextBoxExt.ReadOnly = true;
            IPLastUsableAddressTextBoxExt.Size = new Size(254, 22);
            IPLastUsableAddressTextBoxExt.TabIndex = 16;
            IPLastUsableAddressTextBoxExt.ThemeName = "Default";
            IPLastUsableAddressTextBoxExt.ThemesEnabled = false;
            // 
            // IPTotalsTextBoxExt
            // 
            IPTotalsTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPTotalsTextBoxExt.BackColor = Color.FromArgb(249, 249, 249);
            IPTotalsTextBoxExt.BeforeTouchSize = new Size(254, 22);
            IPTotalsTextBoxExt.BorderColor = SystemColors.ActiveCaptionText;
            IPTotalsTextBoxExt.Font = new Font("Consolas", 9F);
            IPTotalsTextBoxExt.Location = new Point(191, 260);
            IPTotalsTextBoxExt.Margin = new Padding(3, 4, 3, 3);
            IPTotalsTextBoxExt.Name = "IPTotalsTextBoxExt";
            IPTotalsTextBoxExt.ReadOnly = true;
            IPTotalsTextBoxExt.Size = new Size(254, 22);
            IPTotalsTextBoxExt.TabIndex = 17;
            IPTotalsTextBoxExt.ThemeName = "Default";
            IPTotalsTextBoxExt.ThemesEnabled = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 531);
            Controls.Add(MainTabControl);
            Controls.Add(BorderLabel);
            Controls.Add(HeaderPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "BSN Tools";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainTabControl.ResumeLayout(false);
            IPv4NetworkTabPage.ResumeLayout(false);
            IPCalculationToolsSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).EndInit();
            IPCalculationToolsSplitContainer.ResumeLayout(false);
            IPCalculationInfosTableLayoutPanel.ResumeLayout(false);
            IPCalculationInfosTableLayoutPanel.PerformLayout();
            DebugTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IPAddressCIDRTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPNetmaskTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPNetworkAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPBroadcastAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPFirstAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPFirstUsableAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPLastAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPLastUsableAddressTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)IPTotalsTextBoxExt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label BorderLabel;
        private PictureBox pictureBox1;
        private TabControl MainTabControl;
        private TabPage NumericSystemConversionsTabPage;
        private TabPage IPv4NetworkTabPage;
        private Label label1;
        private Label label2;
        private Label VersionLabel;
        private Label CreditsLabel;
        private TabPage StartTabPage;
        private TabPage UnitConversionTabPage;
        private TabPage AboutTabPage;
        private TabPage DebugTabPage;
        private RichTextBox LogRichTextBox;
        private TableLayoutPanel IPCalculationInfosTableLayoutPanel;
        private SplitContainer IPCalculationToolsSplitContainer;
        private Label IPAddressCIDRLabel;
        private Label IPBroadcastAddressLabel;
        private Label IPNetworkAddressLabel;
        private Label IPNetmaskLabel;
        private Label IPFirstAddressLabel;
        private Label IPLastAddressLabel;
        private Label IPTotalsLabel;
        private Label IPLastUsableAddressLabel;
        private Label IPFirstUsableAddressLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPTotalsTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPLastUsableAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPLastAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPFirstUsableAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPFirstAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPBroadcastAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPNetworkAddressTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPNetmaskTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt IPAddressCIDRTextBoxExt;
    }
}
