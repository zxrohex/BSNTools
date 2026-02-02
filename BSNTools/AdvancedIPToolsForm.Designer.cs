namespace BSNTools
{
    partial class AdvancedIPToolsForm
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
            AdvancedIPToolsTabControl = new TabControl();
            VisualizerTabPage = new TabPage();
            IPAddressBitVisualizationTableLayoutPanel = new TableLayoutPanel();
            SubnetbitsLabel = new Label();
            SubnetbitsHeaderLabel = new Label();
            NetbitsLabel = new Label();
            NetbitsHeaderLabel = new Label();
            HostbitsHeaderLabel = new Label();
            HostbitsLabel = new Label();
            tabPage2 = new TabPage();
            AdvancedIPToolsTabControl.SuspendLayout();
            VisualizerTabPage.SuspendLayout();
            IPAddressBitVisualizationTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdvancedIPToolsTabControl
            // 
            AdvancedIPToolsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdvancedIPToolsTabControl.Controls.Add(VisualizerTabPage);
            AdvancedIPToolsTabControl.Controls.Add(tabPage2);
            AdvancedIPToolsTabControl.Location = new Point(12, 12);
            AdvancedIPToolsTabControl.Name = "AdvancedIPToolsTabControl";
            AdvancedIPToolsTabControl.SelectedIndex = 0;
            AdvancedIPToolsTabControl.Size = new Size(701, 407);
            AdvancedIPToolsTabControl.TabIndex = 0;
            // 
            // VisualizerTabPage
            // 
            VisualizerTabPage.Controls.Add(IPAddressBitVisualizationTableLayoutPanel);
            VisualizerTabPage.Location = new Point(4, 24);
            VisualizerTabPage.Name = "VisualizerTabPage";
            VisualizerTabPage.Padding = new Padding(3);
            VisualizerTabPage.Size = new Size(693, 379);
            VisualizerTabPage.TabIndex = 0;
            VisualizerTabPage.Text = "Visualisierung";
            VisualizerTabPage.UseVisualStyleBackColor = true;
            // 
            // IPAddressBitVisualizationTableLayoutPanel
            // 
            IPAddressBitVisualizationTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPAddressBitVisualizationTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            IPAddressBitVisualizationTableLayoutPanel.ColumnCount = 3;
            IPAddressBitVisualizationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.79773F));
            IPAddressBitVisualizationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2022686F));
            IPAddressBitVisualizationTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(SubnetbitsLabel, 1, 1);
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(SubnetbitsHeaderLabel, 1, 0);
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(NetbitsLabel, 0, 1);
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(NetbitsHeaderLabel, 0, 0);
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(HostbitsHeaderLabel, 2, 0);
            IPAddressBitVisualizationTableLayoutPanel.Controls.Add(HostbitsLabel, 2, 1);
            IPAddressBitVisualizationTableLayoutPanel.Location = new Point(6, 6);
            IPAddressBitVisualizationTableLayoutPanel.Name = "IPAddressBitVisualizationTableLayoutPanel";
            IPAddressBitVisualizationTableLayoutPanel.RowCount = 2;
            IPAddressBitVisualizationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 41.4634132F));
            IPAddressBitVisualizationTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 58.5365868F));
            IPAddressBitVisualizationTableLayoutPanel.Size = new Size(681, 82);
            IPAddressBitVisualizationTableLayoutPanel.TabIndex = 0;
            // 
            // SubnetbitsLabel
            // 
            SubnetbitsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubnetbitsLabel.BackColor = Color.FromArgb(255, 190, 0);
            SubnetbitsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SubnetbitsLabel.ForeColor = Color.White;
            SubnetbitsLabel.Location = new Point(439, 36);
            SubnetbitsLabel.Margin = new Padding(0);
            SubnetbitsLabel.Name = "SubnetbitsLabel";
            SubnetbitsLabel.Size = new Size(90, 43);
            SubnetbitsLabel.TabIndex = 5;
            SubnetbitsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubnetbitsHeaderLabel
            // 
            SubnetbitsHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubnetbitsHeaderLabel.BackColor = Color.FromArgb(255, 190, 0);
            SubnetbitsHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SubnetbitsHeaderLabel.ForeColor = Color.White;
            SubnetbitsHeaderLabel.Location = new Point(439, 3);
            SubnetbitsHeaderLabel.Margin = new Padding(0);
            SubnetbitsHeaderLabel.Name = "SubnetbitsHeaderLabel";
            SubnetbitsHeaderLabel.Size = new Size(90, 30);
            SubnetbitsHeaderLabel.TabIndex = 4;
            SubnetbitsHeaderLabel.Text = "Subnetzbits";
            SubnetbitsHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NetbitsLabel
            // 
            NetbitsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NetbitsLabel.BackColor = Color.LimeGreen;
            NetbitsLabel.Font = new Font("Consolas", 9F);
            NetbitsLabel.ForeColor = Color.White;
            NetbitsLabel.Location = new Point(3, 36);
            NetbitsLabel.Margin = new Padding(0);
            NetbitsLabel.Name = "NetbitsLabel";
            NetbitsLabel.Size = new Size(433, 43);
            NetbitsLabel.TabIndex = 2;
            NetbitsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NetbitsHeaderLabel
            // 
            NetbitsHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NetbitsHeaderLabel.BackColor = Color.LimeGreen;
            NetbitsHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NetbitsHeaderLabel.ForeColor = Color.White;
            NetbitsHeaderLabel.Location = new Point(3, 3);
            NetbitsHeaderLabel.Margin = new Padding(0);
            NetbitsHeaderLabel.Name = "NetbitsHeaderLabel";
            NetbitsHeaderLabel.Size = new Size(433, 30);
            NetbitsHeaderLabel.TabIndex = 1;
            NetbitsHeaderLabel.Text = "Netzbits";
            NetbitsHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HostbitsHeaderLabel
            // 
            HostbitsHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HostbitsHeaderLabel.BackColor = Color.FromArgb(115, 159, 208);
            HostbitsHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HostbitsHeaderLabel.ForeColor = Color.White;
            HostbitsHeaderLabel.Location = new Point(532, 3);
            HostbitsHeaderLabel.Margin = new Padding(0);
            HostbitsHeaderLabel.Name = "HostbitsHeaderLabel";
            HostbitsHeaderLabel.Size = new Size(146, 30);
            HostbitsHeaderLabel.TabIndex = 0;
            HostbitsHeaderLabel.Text = "Hostbits";
            HostbitsHeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HostbitsLabel
            // 
            HostbitsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HostbitsLabel.BackColor = Color.FromArgb(115, 159, 208);
            HostbitsLabel.Font = new Font("Consolas", 9F);
            HostbitsLabel.ForeColor = Color.White;
            HostbitsLabel.Location = new Point(532, 36);
            HostbitsLabel.Margin = new Padding(0);
            HostbitsLabel.Name = "HostbitsLabel";
            HostbitsLabel.Size = new Size(146, 43);
            HostbitsLabel.TabIndex = 3;
            HostbitsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(693, 379);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdvancedIPToolsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 431);
            Controls.Add(AdvancedIPToolsTabControl);
            Name = "AdvancedIPToolsForm";
            Text = "Erweiterte IP-Tools";
            AdvancedIPToolsTabControl.ResumeLayout(false);
            VisualizerTabPage.ResumeLayout(false);
            IPAddressBitVisualizationTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl AdvancedIPToolsTabControl;
        private TabPage VisualizerTabPage;
        private TableLayoutPanel IPAddressBitVisualizationTableLayoutPanel;
        private Label HostbitsHeaderLabel;
        private TabPage tabPage2;
        private Label HostbitsLabel;
        private Label NetbitsLabel;
        private Label NetbitsHeaderLabel;
        private Label SubnetbitsLabel;
        private Label SubnetbitsHeaderLabel;
    }
}