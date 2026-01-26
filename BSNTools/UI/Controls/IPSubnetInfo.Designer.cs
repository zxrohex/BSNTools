namespace BSNTools.UI.Controls
{
    partial class IPSubnetInfo
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
            MainTabControl = new TabControl();
            InfoTabPage = new TabPage();
            InfoTableLayoutPanel = new TableLayoutPanel();
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
            AddressesTabPage = new TabPage();
            AllAddressesListBox = new ListBox();
            FilterComboBox = new ComboBox();
            MainTabControl.SuspendLayout();
            InfoTabPage.SuspendLayout();
            InfoTableLayoutPanel.SuspendLayout();
            TotalAddressesGroupBox.SuspendLayout();
            LastUsableAddressGroupBox.SuspendLayout();
            FirstUsableAddressGroupBox.SuspendLayout();
            UsableAddressesGroupBox.SuspendLayout();
            BroadcastAddressGroupBox.SuspendLayout();
            NetworkAddressGroupBox.SuspendLayout();
            SubnetmaskGroupBox.SuspendLayout();
            CIDRGroupBox.SuspendLayout();
            IPAddressGroupBox.SuspendLayout();
            AddressesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(InfoTabPage);
            MainTabControl.Controls.Add(AddressesTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(519, 206);
            MainTabControl.TabIndex = 0;
            MainTabControl.Selected += MainTabControl_Selected;
            // 
            // InfoTabPage
            // 
            InfoTabPage.Controls.Add(InfoTableLayoutPanel);
            InfoTabPage.Location = new Point(4, 24);
            InfoTabPage.Name = "InfoTabPage";
            InfoTabPage.Padding = new Padding(3);
            InfoTabPage.Size = new Size(511, 178);
            InfoTabPage.TabIndex = 0;
            InfoTabPage.Text = "Infos";
            InfoTabPage.UseVisualStyleBackColor = true;
            // 
            // InfoTableLayoutPanel
            // 
            InfoTableLayoutPanel.ColumnCount = 3;
            InfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.Controls.Add(TotalAddressesGroupBox, 2, 2);
            InfoTableLayoutPanel.Controls.Add(LastUsableAddressGroupBox, 1, 2);
            InfoTableLayoutPanel.Controls.Add(FirstUsableAddressGroupBox, 0, 2);
            InfoTableLayoutPanel.Controls.Add(UsableAddressesGroupBox, 2, 1);
            InfoTableLayoutPanel.Controls.Add(BroadcastAddressGroupBox, 1, 1);
            InfoTableLayoutPanel.Controls.Add(NetworkAddressGroupBox, 0, 1);
            InfoTableLayoutPanel.Controls.Add(SubnetmaskGroupBox, 2, 0);
            InfoTableLayoutPanel.Controls.Add(CIDRGroupBox, 1, 0);
            InfoTableLayoutPanel.Controls.Add(IPAddressGroupBox, 0, 0);
            InfoTableLayoutPanel.Dock = DockStyle.Fill;
            InfoTableLayoutPanel.Location = new Point(3, 3);
            InfoTableLayoutPanel.Name = "InfoTableLayoutPanel";
            InfoTableLayoutPanel.RowCount = 3;
            InfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoTableLayoutPanel.Size = new Size(505, 172);
            InfoTableLayoutPanel.TabIndex = 0;
            // 
            // TotalAddressesGroupBox
            // 
            TotalAddressesGroupBox.Controls.Add(TotalAddressesTextBox);
            TotalAddressesGroupBox.Location = new Point(339, 117);
            TotalAddressesGroupBox.Name = "TotalAddressesGroupBox";
            TotalAddressesGroupBox.Size = new Size(162, 51);
            TotalAddressesGroupBox.TabIndex = 8;
            TotalAddressesGroupBox.TabStop = false;
            TotalAddressesGroupBox.Text = "Totale Adressen";
            // 
            // TotalAddressesTextBox
            // 
            TotalAddressesTextBox.Dock = DockStyle.Fill;
            TotalAddressesTextBox.Location = new Point(3, 19);
            TotalAddressesTextBox.Name = "TotalAddressesTextBox";
            TotalAddressesTextBox.ReadOnly = true;
            TotalAddressesTextBox.Size = new Size(156, 23);
            TotalAddressesTextBox.TabIndex = 1;
            // 
            // LastUsableAddressGroupBox
            // 
            LastUsableAddressGroupBox.Controls.Add(LastUsableAddressTextBox);
            LastUsableAddressGroupBox.Location = new Point(171, 117);
            LastUsableAddressGroupBox.Name = "LastUsableAddressGroupBox";
            LastUsableAddressGroupBox.Size = new Size(162, 51);
            LastUsableAddressGroupBox.TabIndex = 7;
            LastUsableAddressGroupBox.TabStop = false;
            LastUsableAddressGroupBox.Text = "Letzte nutzbare Adresse";
            // 
            // LastUsableAddressTextBox
            // 
            LastUsableAddressTextBox.Dock = DockStyle.Fill;
            LastUsableAddressTextBox.Location = new Point(3, 19);
            LastUsableAddressTextBox.Name = "LastUsableAddressTextBox";
            LastUsableAddressTextBox.ReadOnly = true;
            LastUsableAddressTextBox.Size = new Size(156, 23);
            LastUsableAddressTextBox.TabIndex = 1;
            // 
            // FirstUsableAddressGroupBox
            // 
            FirstUsableAddressGroupBox.Controls.Add(FirstUsableAddressTextBox);
            FirstUsableAddressGroupBox.Location = new Point(3, 117);
            FirstUsableAddressGroupBox.Name = "FirstUsableAddressGroupBox";
            FirstUsableAddressGroupBox.Size = new Size(162, 51);
            FirstUsableAddressGroupBox.TabIndex = 6;
            FirstUsableAddressGroupBox.TabStop = false;
            FirstUsableAddressGroupBox.Text = "Erste nutzbare Adresse";
            // 
            // FirstUsableAddressTextBox
            // 
            FirstUsableAddressTextBox.Dock = DockStyle.Fill;
            FirstUsableAddressTextBox.Location = new Point(3, 19);
            FirstUsableAddressTextBox.Name = "FirstUsableAddressTextBox";
            FirstUsableAddressTextBox.ReadOnly = true;
            FirstUsableAddressTextBox.Size = new Size(156, 23);
            FirstUsableAddressTextBox.TabIndex = 1;
            // 
            // UsableAddressesGroupBox
            // 
            UsableAddressesGroupBox.Controls.Add(UsableAddressesTextBox);
            UsableAddressesGroupBox.Location = new Point(339, 60);
            UsableAddressesGroupBox.Name = "UsableAddressesGroupBox";
            UsableAddressesGroupBox.Size = new Size(162, 51);
            UsableAddressesGroupBox.TabIndex = 5;
            UsableAddressesGroupBox.TabStop = false;
            UsableAddressesGroupBox.Text = "Nutzbare Adressen";
            // 
            // UsableAddressesTextBox
            // 
            UsableAddressesTextBox.Dock = DockStyle.Fill;
            UsableAddressesTextBox.Location = new Point(3, 19);
            UsableAddressesTextBox.Name = "UsableAddressesTextBox";
            UsableAddressesTextBox.ReadOnly = true;
            UsableAddressesTextBox.Size = new Size(156, 23);
            UsableAddressesTextBox.TabIndex = 1;
            // 
            // BroadcastAddressGroupBox
            // 
            BroadcastAddressGroupBox.Controls.Add(BroadcastAddressTextBox);
            BroadcastAddressGroupBox.Location = new Point(171, 60);
            BroadcastAddressGroupBox.Name = "BroadcastAddressGroupBox";
            BroadcastAddressGroupBox.Size = new Size(162, 51);
            BroadcastAddressGroupBox.TabIndex = 4;
            BroadcastAddressGroupBox.TabStop = false;
            BroadcastAddressGroupBox.Text = "Broadcastadresse";
            // 
            // BroadcastAddressTextBox
            // 
            BroadcastAddressTextBox.Dock = DockStyle.Fill;
            BroadcastAddressTextBox.Location = new Point(3, 19);
            BroadcastAddressTextBox.Name = "BroadcastAddressTextBox";
            BroadcastAddressTextBox.ReadOnly = true;
            BroadcastAddressTextBox.Size = new Size(156, 23);
            BroadcastAddressTextBox.TabIndex = 1;
            // 
            // NetworkAddressGroupBox
            // 
            NetworkAddressGroupBox.Controls.Add(NetworkAddressTextBox);
            NetworkAddressGroupBox.Location = new Point(3, 60);
            NetworkAddressGroupBox.Name = "NetworkAddressGroupBox";
            NetworkAddressGroupBox.Size = new Size(162, 51);
            NetworkAddressGroupBox.TabIndex = 3;
            NetworkAddressGroupBox.TabStop = false;
            NetworkAddressGroupBox.Text = "Netzwerkadresse";
            // 
            // NetworkAddressTextBox
            // 
            NetworkAddressTextBox.Dock = DockStyle.Fill;
            NetworkAddressTextBox.Location = new Point(3, 19);
            NetworkAddressTextBox.Name = "NetworkAddressTextBox";
            NetworkAddressTextBox.ReadOnly = true;
            NetworkAddressTextBox.Size = new Size(156, 23);
            NetworkAddressTextBox.TabIndex = 1;
            // 
            // SubnetmaskGroupBox
            // 
            SubnetmaskGroupBox.Controls.Add(SubnetmaskTextBox);
            SubnetmaskGroupBox.Location = new Point(339, 3);
            SubnetmaskGroupBox.Name = "SubnetmaskGroupBox";
            SubnetmaskGroupBox.Size = new Size(162, 51);
            SubnetmaskGroupBox.TabIndex = 2;
            SubnetmaskGroupBox.TabStop = false;
            SubnetmaskGroupBox.Text = "Subnetzmaske";
            // 
            // SubnetmaskTextBox
            // 
            SubnetmaskTextBox.Dock = DockStyle.Fill;
            SubnetmaskTextBox.Location = new Point(3, 19);
            SubnetmaskTextBox.Name = "SubnetmaskTextBox";
            SubnetmaskTextBox.ReadOnly = true;
            SubnetmaskTextBox.Size = new Size(156, 23);
            SubnetmaskTextBox.TabIndex = 1;
            // 
            // CIDRGroupBox
            // 
            CIDRGroupBox.Controls.Add(CIDRTextBox);
            CIDRGroupBox.Location = new Point(171, 3);
            CIDRGroupBox.Name = "CIDRGroupBox";
            CIDRGroupBox.Size = new Size(162, 51);
            CIDRGroupBox.TabIndex = 1;
            CIDRGroupBox.TabStop = false;
            CIDRGroupBox.Text = "CIDR";
            // 
            // CIDRTextBox
            // 
            CIDRTextBox.Dock = DockStyle.Fill;
            CIDRTextBox.Location = new Point(3, 19);
            CIDRTextBox.Name = "CIDRTextBox";
            CIDRTextBox.ReadOnly = true;
            CIDRTextBox.Size = new Size(156, 23);
            CIDRTextBox.TabIndex = 1;
            // 
            // IPAddressGroupBox
            // 
            IPAddressGroupBox.Controls.Add(IPAddressTextBox);
            IPAddressGroupBox.Location = new Point(3, 3);
            IPAddressGroupBox.Name = "IPAddressGroupBox";
            IPAddressGroupBox.Size = new Size(162, 51);
            IPAddressGroupBox.TabIndex = 0;
            IPAddressGroupBox.TabStop = false;
            IPAddressGroupBox.Text = "IP-Adresse";
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Dock = DockStyle.Fill;
            IPAddressTextBox.Location = new Point(3, 19);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.ReadOnly = true;
            IPAddressTextBox.Size = new Size(156, 23);
            IPAddressTextBox.TabIndex = 0;
            // 
            // AddressesTabPage
            // 
            AddressesTabPage.Controls.Add(AllAddressesListBox);
            AddressesTabPage.Controls.Add(FilterComboBox);
            AddressesTabPage.Location = new Point(4, 24);
            AddressesTabPage.Name = "AddressesTabPage";
            AddressesTabPage.Padding = new Padding(3);
            AddressesTabPage.Size = new Size(511, 178);
            AddressesTabPage.TabIndex = 1;
            AddressesTabPage.Text = "Adressen";
            AddressesTabPage.UseVisualStyleBackColor = true;
            // 
            // AllAddressesListBox
            // 
            AllAddressesListBox.Dock = DockStyle.Fill;
            AllAddressesListBox.FormattingEnabled = true;
            AllAddressesListBox.Location = new Point(3, 26);
            AllAddressesListBox.Name = "AllAddressesListBox";
            AllAddressesListBox.Size = new Size(505, 149);
            AllAddressesListBox.TabIndex = 0;
            // 
            // FilterComboBox
            // 
            FilterComboBox.Dock = DockStyle.Top;
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "Nur Nutzbare anzeigen", "Alle anzeigen" });
            FilterComboBox.Location = new Point(3, 3);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(505, 23);
            FilterComboBox.TabIndex = 1;
            FilterComboBox.SelectedIndexChanged += FilterListBox_SelectedIndexChanged;
            // 
            // IPSubnetInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTabControl);
            Name = "IPSubnetInfo";
            Size = new Size(519, 206);
            MainTabControl.ResumeLayout(false);
            InfoTabPage.ResumeLayout(false);
            InfoTableLayoutPanel.ResumeLayout(false);
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
            AddressesTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage InfoTabPage;
        private TabPage AddressesTabPage;
        private TableLayoutPanel InfoTableLayoutPanel;
        private GroupBox TotalAddressesGroupBox;
        private GroupBox LastUsableAddressGroupBox;
        private GroupBox FirstUsableAddressGroupBox;
        private GroupBox UsableAddressesGroupBox;
        private GroupBox BroadcastAddressGroupBox;
        private GroupBox NetworkAddressGroupBox;
        private GroupBox SubnetmaskGroupBox;
        private GroupBox CIDRGroupBox;
        private GroupBox IPAddressGroupBox;
        private TextBox TotalAddressesTextBox;
        private TextBox LastUsableAddressTextBox;
        private TextBox FirstUsableAddressTextBox;
        private TextBox UsableAddressesTextBox;
        private TextBox BroadcastAddressTextBox;
        private TextBox NetworkAddressTextBox;
        private TextBox SubnetmaskTextBox;
        private TextBox CIDRTextBox;
        private TextBox IPAddressTextBox;
        private ListBox AllAddressesListBox;
        private ComboBox FilterComboBox;
    }
}
