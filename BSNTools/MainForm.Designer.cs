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
            AppSubtitleLabel = new Label();
            AppTitleLabel = new Label();
            AppLogoPictureBox = new PictureBox();
            BorderLabel = new Label();
            MainTabControl = new TabControl();
            StartTabPage = new TabPage();
            ConversionsAndCalculationsTabPage = new TabPage();
            ConversionCalculationToolContainerPanel = new Panel();
            ConversionCalculationToolsMenu = new Syncfusion.Windows.Forms.Tools.GroupView();
            IPv4NetworkTabPage = new TabPage();
            IPInputConfigGroupBox = new GroupBox();
            IPInputConfigTableLayoutPanel = new TableLayoutPanel();
            IPMainInputsPanel = new Panel();
            IPSubnetCIDRInputTextBox = new TextBox();
            IPAddressInputTextBox = new TextBox();
            IPInputsCalcStatsLabel = new Label();
            IPCalcActionsPanel = new Panel();
            IPCalculateButton = new Button();
            IPCalculationToolsSplitContainer = new SplitContainer();
            AdvancedViewButton = new Button();
            WildcardMaskToggleButton = new Button();
            BitFormToggleButton = new Button();
            AboutTabPage = new TabPage();
            DebugTabPage = new TabPage();
            LogRichTextBox = new RichTextBox();
            label1 = new Label();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppLogoPictureBox).BeginInit();
            MainTabControl.SuspendLayout();
            StartTabPage.SuspendLayout();
            ConversionsAndCalculationsTabPage.SuspendLayout();
            IPv4NetworkTabPage.SuspendLayout();
            IPInputConfigGroupBox.SuspendLayout();
            IPInputConfigTableLayoutPanel.SuspendLayout();
            IPMainInputsPanel.SuspendLayout();
            IPCalcActionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).BeginInit();
            IPCalculationToolsSplitContainer.Panel2.SuspendLayout();
            IPCalculationToolsSplitContainer.SuspendLayout();
            DebugTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.Controls.Add(CreditsLabel);
            HeaderPanel.Controls.Add(VersionLabel);
            HeaderPanel.Controls.Add(AppSubtitleLabel);
            HeaderPanel.Controls.Add(AppTitleLabel);
            HeaderPanel.Controls.Add(AppLogoPictureBox);
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
            VersionLabel.Location = new Point(421, 11);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(288, 15);
            VersionLabel.TabIndex = 3;
            VersionLabel.Text = "Version %Version%";
            VersionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AppSubtitleLabel
            // 
            AppSubtitleLabel.AutoSize = true;
            AppSubtitleLabel.Location = new Point(64, 26);
            AppSubtitleLabel.Margin = new Padding(2, 0, 2, 0);
            AppSubtitleLabel.Name = "AppSubtitleLabel";
            AppSubtitleLabel.Size = new Size(159, 15);
            AppSubtitleLabel.TabIndex = 2;
            AppSubtitleLabel.Text = "Tools für den BSN-Unterricht";
            // 
            // AppTitleLabel
            // 
            AppTitleLabel.AutoSize = true;
            AppTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AppTitleLabel.Location = new Point(64, 11);
            AppTitleLabel.Margin = new Padding(2, 0, 2, 0);
            AppTitleLabel.Name = "AppTitleLabel";
            AppTitleLabel.Size = new Size(64, 15);
            AppTitleLabel.TabIndex = 1;
            AppTitleLabel.Text = "BSN-Tools";
            // 
            // AppLogoPictureBox
            // 
            AppLogoPictureBox.Image = Properties.Resources.BSNToolsLogo;
            AppLogoPictureBox.Location = new Point(12, 9);
            AppLogoPictureBox.Margin = new Padding(2);
            AppLogoPictureBox.Name = "AppLogoPictureBox";
            AppLogoPictureBox.Size = new Size(47, 38);
            AppLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AppLogoPictureBox.TabIndex = 0;
            AppLogoPictureBox.TabStop = false;
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
            MainTabControl.Controls.Add(ConversionsAndCalculationsTabPage);
            MainTabControl.Controls.Add(IPv4NetworkTabPage);
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
            StartTabPage.Controls.Add(label1);
            StartTabPage.Location = new Point(4, 24);
            StartTabPage.Name = "StartTabPage";
            StartTabPage.Padding = new Padding(3);
            StartTabPage.Size = new Size(689, 432);
            StartTabPage.TabIndex = 2;
            StartTabPage.Text = "Start";
            StartTabPage.UseVisualStyleBackColor = true;
            // 
            // ConversionsAndCalculationsTabPage
            // 
            ConversionsAndCalculationsTabPage.Controls.Add(ConversionCalculationToolContainerPanel);
            ConversionsAndCalculationsTabPage.Controls.Add(ConversionCalculationToolsMenu);
            ConversionsAndCalculationsTabPage.Location = new Point(4, 24);
            ConversionsAndCalculationsTabPage.Margin = new Padding(2);
            ConversionsAndCalculationsTabPage.Name = "ConversionsAndCalculationsTabPage";
            ConversionsAndCalculationsTabPage.Padding = new Padding(2);
            ConversionsAndCalculationsTabPage.Size = new Size(689, 432);
            ConversionsAndCalculationsTabPage.TabIndex = 0;
            ConversionsAndCalculationsTabPage.Text = "Umrechnung/Konversion";
            ConversionsAndCalculationsTabPage.UseVisualStyleBackColor = true;
            // 
            // ConversionCalculationToolContainerPanel
            // 
            ConversionCalculationToolContainerPanel.Dock = DockStyle.Fill;
            ConversionCalculationToolContainerPanel.Location = new Point(165, 2);
            ConversionCalculationToolContainerPanel.Name = "ConversionCalculationToolContainerPanel";
            ConversionCalculationToolContainerPanel.Size = new Size(522, 428);
            ConversionCalculationToolContainerPanel.TabIndex = 1;
            // 
            // ConversionCalculationToolsMenu
            // 
            ConversionCalculationToolsMenu.BackColor = SystemColors.Control;
            ConversionCalculationToolsMenu.ButtonView = true;
            ConversionCalculationToolsMenu.Dock = DockStyle.Left;
            ConversionCalculationToolsMenu.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] { new Syncfusion.Windows.Forms.Tools.GroupViewItem("Umrechnen", -1, true, null, "GroupViewItem0"), new Syncfusion.Windows.Forms.Tools.GroupViewItem("Konvertieren", -1, true, null, "GroupViewItem1") });
            ConversionCalculationToolsMenu.Location = new Point(2, 2);
            ConversionCalculationToolsMenu.Name = "ConversionCalculationToolsMenu";
            ConversionCalculationToolsMenu.SelectedItem = 0;
            ConversionCalculationToolsMenu.Size = new Size(163, 428);
            ConversionCalculationToolsMenu.TabIndex = 0;
            ConversionCalculationToolsMenu.Text = "groupView1";
            ConversionCalculationToolsMenu.ThemeName = "Default";
            ConversionCalculationToolsMenu.GroupViewItemSelected += ConversionCalculationToolsMenu_GroupViewItemSelected;
            // 
            // IPv4NetworkTabPage
            // 
            IPv4NetworkTabPage.Controls.Add(IPInputConfigGroupBox);
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
            // IPInputConfigGroupBox
            // 
            IPInputConfigGroupBox.Controls.Add(IPInputConfigTableLayoutPanel);
            IPInputConfigGroupBox.Location = new Point(20, 15);
            IPInputConfigGroupBox.Name = "IPInputConfigGroupBox";
            IPInputConfigGroupBox.Size = new Size(648, 63);
            IPInputConfigGroupBox.TabIndex = 2;
            IPInputConfigGroupBox.TabStop = false;
            IPInputConfigGroupBox.Text = "IP-Eingabe";
            // 
            // IPInputConfigTableLayoutPanel
            // 
            IPInputConfigTableLayoutPanel.ColumnCount = 3;
            IPInputConfigTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.653244F));
            IPInputConfigTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.346756F));
            IPInputConfigTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            IPInputConfigTableLayoutPanel.Controls.Add(IPMainInputsPanel, 0, 0);
            IPInputConfigTableLayoutPanel.Controls.Add(IPInputsCalcStatsLabel, 1, 0);
            IPInputConfigTableLayoutPanel.Controls.Add(IPCalcActionsPanel, 2, 0);
            IPInputConfigTableLayoutPanel.Dock = DockStyle.Fill;
            IPInputConfigTableLayoutPanel.Location = new Point(3, 19);
            IPInputConfigTableLayoutPanel.Name = "IPInputConfigTableLayoutPanel";
            IPInputConfigTableLayoutPanel.RowCount = 1;
            IPInputConfigTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IPInputConfigTableLayoutPanel.Size = new Size(642, 41);
            IPInputConfigTableLayoutPanel.TabIndex = 0;
            // 
            // IPMainInputsPanel
            // 
            IPMainInputsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPMainInputsPanel.Controls.Add(IPSubnetCIDRInputTextBox);
            IPMainInputsPanel.Controls.Add(IPAddressInputTextBox);
            IPMainInputsPanel.Location = new Point(3, 3);
            IPMainInputsPanel.Name = "IPMainInputsPanel";
            IPMainInputsPanel.Size = new Size(283, 35);
            IPMainInputsPanel.TabIndex = 0;
            // 
            // IPSubnetCIDRInputTextBox
            // 
            IPSubnetCIDRInputTextBox.Location = new Point(198, 6);
            IPSubnetCIDRInputTextBox.Name = "IPSubnetCIDRInputTextBox";
            IPSubnetCIDRInputTextBox.PlaceholderText = "Subnet-CIDR";
            IPSubnetCIDRInputTextBox.Size = new Size(78, 23);
            IPSubnetCIDRInputTextBox.TabIndex = 1;
            IPSubnetCIDRInputTextBox.TextChanged += IPInputTextBoxes_TextChanged;
            // 
            // IPAddressInputTextBox
            // 
            IPAddressInputTextBox.Location = new Point(7, 6);
            IPAddressInputTextBox.Name = "IPAddressInputTextBox";
            IPAddressInputTextBox.PlaceholderText = "IP-Adresse/CIDR";
            IPAddressInputTextBox.Size = new Size(187, 23);
            IPAddressInputTextBox.TabIndex = 0;
            IPAddressInputTextBox.TextChanged += IPInputTextBoxes_TextChanged;
            // 
            // IPInputsCalcStatsLabel
            // 
            IPInputsCalcStatsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPInputsCalcStatsLabel.BorderStyle = BorderStyle.Fixed3D;
            IPInputsCalcStatsLabel.Location = new Point(298, 9);
            IPInputsCalcStatsLabel.Margin = new Padding(9);
            IPInputsCalcStatsLabel.Name = "IPInputsCalcStatsLabel";
            IPInputsCalcStatsLabel.Size = new Size(140, 23);
            IPInputsCalcStatsLabel.TabIndex = 1;
            IPInputsCalcStatsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IPCalcActionsPanel
            // 
            IPCalcActionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPCalcActionsPanel.Controls.Add(IPCalculateButton);
            IPCalcActionsPanel.Location = new Point(453, 6);
            IPCalcActionsPanel.Margin = new Padding(6);
            IPCalcActionsPanel.Name = "IPCalcActionsPanel";
            IPCalcActionsPanel.Size = new Size(183, 29);
            IPCalcActionsPanel.TabIndex = 2;
            // 
            // IPCalculateButton
            // 
            IPCalculateButton.Dock = DockStyle.Fill;
            IPCalculateButton.Location = new Point(0, 0);
            IPCalculateButton.Name = "IPCalculateButton";
            IPCalculateButton.Size = new Size(183, 29);
            IPCalculateButton.TabIndex = 0;
            IPCalculateButton.Text = "Berechnen";
            IPCalculateButton.UseVisualStyleBackColor = true;
            IPCalculateButton.Click += IPCalculateButton_Click;
            // 
            // IPCalculationToolsSplitContainer
            // 
            IPCalculationToolsSplitContainer.BorderStyle = BorderStyle.Fixed3D;
            IPCalculationToolsSplitContainer.Location = new Point(20, 86);
            IPCalculationToolsSplitContainer.Name = "IPCalculationToolsSplitContainer";
            // 
            // IPCalculationToolsSplitContainer.Panel2
            // 
            IPCalculationToolsSplitContainer.Panel2.Controls.Add(AdvancedViewButton);
            IPCalculationToolsSplitContainer.Panel2.Controls.Add(WildcardMaskToggleButton);
            IPCalculationToolsSplitContainer.Panel2.Controls.Add(BitFormToggleButton);
            IPCalculationToolsSplitContainer.Panel2.Enabled = false;
            IPCalculationToolsSplitContainer.Size = new Size(648, 332);
            IPCalculationToolsSplitContainer.SplitterDistance = 452;
            IPCalculationToolsSplitContainer.TabIndex = 1;
            // 
            // AdvancedViewButton
            // 
            AdvancedViewButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdvancedViewButton.Location = new Point(39, 219);
            AdvancedViewButton.Name = "AdvancedViewButton";
            AdvancedViewButton.Size = new Size(110, 98);
            AdvancedViewButton.TabIndex = 2;
            AdvancedViewButton.Text = "Erweitert";
            AdvancedViewButton.UseVisualStyleBackColor = true;
            AdvancedViewButton.Click += AdvancedViewButton_Click;
            // 
            // WildcardMaskToggleButton
            // 
            WildcardMaskToggleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            WildcardMaskToggleButton.Location = new Point(39, 115);
            WildcardMaskToggleButton.Name = "WildcardMaskToggleButton";
            WildcardMaskToggleButton.Size = new Size(110, 98);
            WildcardMaskToggleButton.TabIndex = 1;
            WildcardMaskToggleButton.Text = "Wildcard-Maske:\r\nAus";
            WildcardMaskToggleButton.UseVisualStyleBackColor = true;
            WildcardMaskToggleButton.Click += WildcardMaskToggleButton_Click;
            // 
            // BitFormToggleButton
            // 
            BitFormToggleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BitFormToggleButton.Image = Properties.Resources.Binary_32xLG;
            BitFormToggleButton.Location = new Point(39, 11);
            BitFormToggleButton.Name = "BitFormToggleButton";
            BitFormToggleButton.Size = new Size(110, 98);
            BitFormToggleButton.TabIndex = 0;
            BitFormToggleButton.Text = "Bitform:\r\nAus";
            BitFormToggleButton.TextAlign = ContentAlignment.BottomCenter;
            BitFormToggleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BitFormToggleButton.UseVisualStyleBackColor = true;
            BitFormToggleButton.Click += BitFormToggleButton_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold);
            label1.Location = new Point(280, 44);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "BSN-Tools";
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BSN-Tools";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppLogoPictureBox).EndInit();
            MainTabControl.ResumeLayout(false);
            StartTabPage.ResumeLayout(false);
            StartTabPage.PerformLayout();
            ConversionsAndCalculationsTabPage.ResumeLayout(false);
            IPv4NetworkTabPage.ResumeLayout(false);
            IPInputConfigGroupBox.ResumeLayout(false);
            IPInputConfigTableLayoutPanel.ResumeLayout(false);
            IPMainInputsPanel.ResumeLayout(false);
            IPMainInputsPanel.PerformLayout();
            IPCalcActionsPanel.ResumeLayout(false);
            IPCalculationToolsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).EndInit();
            IPCalculationToolsSplitContainer.ResumeLayout(false);
            DebugTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label BorderLabel;
        private PictureBox AppLogoPictureBox;
        private TabControl MainTabControl;
        private TabPage ConversionsAndCalculationsTabPage;
        private TabPage IPv4NetworkTabPage;
        private Label AppTitleLabel;
        private Label AppSubtitleLabel;
        private Label VersionLabel;
        private Label CreditsLabel;
        private TabPage StartTabPage;
        private TabPage AboutTabPage;
        private TabPage DebugTabPage;
        private RichTextBox LogRichTextBox;
        private SplitContainer IPCalculationToolsSplitContainer;
        private GroupBox IPInputConfigGroupBox;
        private TableLayoutPanel IPInputConfigTableLayoutPanel;
        private Panel IPMainInputsPanel;
        private TextBox IPSubnetCIDRInputTextBox;
        private TextBox IPAddressInputTextBox;
        private Label IPInputsCalcStatsLabel;
        private Panel IPCalcActionsPanel;
        private Button IPCalculateButton;
        private Syncfusion.Windows.Forms.Tools.GroupView ConversionCalculationToolsMenu;
        private Panel ConversionCalculationToolContainerPanel;
        private Button BitFormToggleButton;
        private Button WildcardMaskToggleButton;
        private Button AdvancedViewButton;
        private Label label1;
    }
}
