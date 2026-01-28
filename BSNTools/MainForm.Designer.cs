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
            IPInputConfigGroupBox = new GroupBox();
            IPInputConfigTableLayoutPanel = new TableLayoutPanel();
            IPCalculationToolsSplitContainer = new SplitContainer();
            UnitConversionTabPage = new TabPage();
            AboutTabPage = new TabPage();
            DebugTabPage = new TabPage();
            LogRichTextBox = new RichTextBox();
            IPMainInputsPanel = new Panel();
            IPAddressInputTextBox = new TextBox();
            IPSubnetCIDRInputTextBox = new TextBox();
            IPInputsCalcStatsLabel = new Label();
            IPCalcActionsPanel = new Panel();
            IPCalculateButton = new Button();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainTabControl.SuspendLayout();
            IPv4NetworkTabPage.SuspendLayout();
            IPInputConfigGroupBox.SuspendLayout();
            IPInputConfigTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).BeginInit();
            IPCalculationToolsSplitContainer.SuspendLayout();
            DebugTabPage.SuspendLayout();
            IPMainInputsPanel.SuspendLayout();
            IPCalcActionsPanel.SuspendLayout();
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
            // IPCalculationToolsSplitContainer
            // 
            IPCalculationToolsSplitContainer.BorderStyle = BorderStyle.Fixed3D;
            IPCalculationToolsSplitContainer.Location = new Point(20, 86);
            IPCalculationToolsSplitContainer.Name = "IPCalculationToolsSplitContainer";
            IPCalculationToolsSplitContainer.Size = new Size(648, 332);
            IPCalculationToolsSplitContainer.SplitterDistance = 452;
            IPCalculationToolsSplitContainer.TabIndex = 1;
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
            // IPAddressInputTextBox
            // 
            IPAddressInputTextBox.Location = new Point(7, 6);
            IPAddressInputTextBox.Name = "IPAddressInputTextBox";
            IPAddressInputTextBox.Size = new Size(187, 23);
            IPAddressInputTextBox.TabIndex = 0;
            // 
            // IPSubnetCIDRInputTextBox
            // 
            IPSubnetCIDRInputTextBox.Location = new Point(198, 6);
            IPSubnetCIDRInputTextBox.Name = "IPSubnetCIDRInputTextBox";
            IPSubnetCIDRInputTextBox.Size = new Size(78, 23);
            IPSubnetCIDRInputTextBox.TabIndex = 1;
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
            IPInputConfigGroupBox.ResumeLayout(false);
            IPInputConfigTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IPCalculationToolsSplitContainer).EndInit();
            IPCalculationToolsSplitContainer.ResumeLayout(false);
            DebugTabPage.ResumeLayout(false);
            IPMainInputsPanel.ResumeLayout(false);
            IPMainInputsPanel.PerformLayout();
            IPCalcActionsPanel.ResumeLayout(false);
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
        private SplitContainer IPCalculationToolsSplitContainer;
        private GroupBox IPInputConfigGroupBox;
        private TableLayoutPanel IPInputConfigTableLayoutPanel;
        private Panel IPMainInputsPanel;
        private TextBox IPSubnetCIDRInputTextBox;
        private TextBox IPAddressInputTextBox;
        private Label IPInputsCalcStatsLabel;
        private Panel IPCalcActionsPanel;
        private Button IPCalculateButton;
    }
}
