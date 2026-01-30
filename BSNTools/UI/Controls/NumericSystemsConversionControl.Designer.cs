namespace BSNTools.UI.Controls
{
    partial class NumericSystemsConversionControl
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
            NumericSystemsConversionToolsTabControl = new TabControl();
            tabPage1 = new TabPage();
            SimpleNumericSystemsConversionTableLayoutPanel = new TableLayoutPanel();
            OctalTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            HexTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            BinaryTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            DecimalLabel = new Label();
            BinaryLabel = new Label();
            HexLabel = new Label();
            OctalLabel = new Label();
            DecimalTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            tabPage2 = new TabPage();
            NumericSystemsConversionToolsTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SimpleNumericSystemsConversionTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OctalTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HexTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinaryTextBoxExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DecimalTextBoxExt).BeginInit();
            SuspendLayout();
            // 
            // NumericSystemsConversionToolsTabControl
            // 
            NumericSystemsConversionToolsTabControl.Controls.Add(tabPage1);
            NumericSystemsConversionToolsTabControl.Controls.Add(tabPage2);
            NumericSystemsConversionToolsTabControl.Dock = DockStyle.Fill;
            NumericSystemsConversionToolsTabControl.Location = new Point(0, 0);
            NumericSystemsConversionToolsTabControl.Name = "NumericSystemsConversionToolsTabControl";
            NumericSystemsConversionToolsTabControl.SelectedIndex = 0;
            NumericSystemsConversionToolsTabControl.Size = new Size(526, 432);
            NumericSystemsConversionToolsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SimpleNumericSystemsConversionTableLayoutPanel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(518, 404);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Simpel";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SimpleNumericSystemsConversionTableLayoutPanel
            // 
            SimpleNumericSystemsConversionTableLayoutPanel.BackColor = Color.Transparent;
            SimpleNumericSystemsConversionTableLayoutPanel.ColumnCount = 2;
            SimpleNumericSystemsConversionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            SimpleNumericSystemsConversionTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(OctalTextBoxExt, 1, 3);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(HexTextBoxExt, 1, 2);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(BinaryTextBoxExt, 1, 1);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(DecimalLabel, 0, 0);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(BinaryLabel, 0, 1);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(HexLabel, 0, 2);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(OctalLabel, 0, 3);
            SimpleNumericSystemsConversionTableLayoutPanel.Controls.Add(DecimalTextBoxExt, 1, 0);
            SimpleNumericSystemsConversionTableLayoutPanel.Dock = DockStyle.Fill;
            SimpleNumericSystemsConversionTableLayoutPanel.Location = new Point(3, 3);
            SimpleNumericSystemsConversionTableLayoutPanel.Name = "SimpleNumericSystemsConversionTableLayoutPanel";
            SimpleNumericSystemsConversionTableLayoutPanel.RowCount = 4;
            SimpleNumericSystemsConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SimpleNumericSystemsConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SimpleNumericSystemsConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SimpleNumericSystemsConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            SimpleNumericSystemsConversionTableLayoutPanel.Size = new Size(512, 398);
            SimpleNumericSystemsConversionTableLayoutPanel.TabIndex = 0;
            // 
            // OctalTextBoxExt
            // 
            OctalTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OctalTextBoxExt.BeforeTouchSize = new Size(409, 93);
            OctalTextBoxExt.Font = new Font("Consolas", 9F);
            OctalTextBoxExt.Location = new Point(100, 300);
            OctalTextBoxExt.Multiline = true;
            OctalTextBoxExt.Name = "OctalTextBoxExt";
            OctalTextBoxExt.Size = new Size(409, 95);
            OctalTextBoxExt.TabIndex = 7;
            OctalTextBoxExt.ThemesEnabled = false;
            OctalTextBoxExt.TextChanged += InputTextBoxExts_TextChanged;
            OctalTextBoxExt.KeyDown += InputTextBoxExts_KeyDown;
            // 
            // HexTextBoxExt
            // 
            HexTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HexTextBoxExt.BeforeTouchSize = new Size(409, 93);
            HexTextBoxExt.Font = new Font("Consolas", 9F);
            HexTextBoxExt.Location = new Point(100, 201);
            HexTextBoxExt.Multiline = true;
            HexTextBoxExt.Name = "HexTextBoxExt";
            HexTextBoxExt.Size = new Size(409, 93);
            HexTextBoxExt.TabIndex = 6;
            HexTextBoxExt.ThemesEnabled = false;
            HexTextBoxExt.TextChanged += InputTextBoxExts_TextChanged;
            HexTextBoxExt.KeyDown += InputTextBoxExts_KeyDown;
            // 
            // BinaryTextBoxExt
            // 
            BinaryTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BinaryTextBoxExt.BeforeTouchSize = new Size(409, 93);
            BinaryTextBoxExt.Font = new Font("Consolas", 9F);
            BinaryTextBoxExt.Location = new Point(100, 102);
            BinaryTextBoxExt.Multiline = true;
            BinaryTextBoxExt.Name = "BinaryTextBoxExt";
            BinaryTextBoxExt.Size = new Size(409, 93);
            BinaryTextBoxExt.TabIndex = 5;
            BinaryTextBoxExt.ThemesEnabled = false;
            BinaryTextBoxExt.TextChanged += InputTextBoxExts_TextChanged;
            BinaryTextBoxExt.KeyDown += InputTextBoxExts_KeyDown;
            // 
            // DecimalLabel
            // 
            DecimalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DecimalLabel.AutoSize = true;
            DecimalLabel.Font = new Font("Consolas", 9F);
            DecimalLabel.Location = new Point(3, 0);
            DecimalLabel.Name = "DecimalLabel";
            DecimalLabel.Size = new Size(63, 99);
            DecimalLabel.TabIndex = 0;
            DecimalLabel.Text = "Dezimal:";
            DecimalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BinaryLabel
            // 
            BinaryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BinaryLabel.AutoSize = true;
            BinaryLabel.Font = new Font("Consolas", 9F);
            BinaryLabel.Location = new Point(3, 99);
            BinaryLabel.Name = "BinaryLabel";
            BinaryLabel.Size = new Size(49, 99);
            BinaryLabel.TabIndex = 1;
            BinaryLabel.Text = "Binär:";
            BinaryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HexLabel
            // 
            HexLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            HexLabel.AutoSize = true;
            HexLabel.Font = new Font("Consolas", 9F);
            HexLabel.Location = new Point(3, 198);
            HexLabel.Name = "HexLabel";
            HexLabel.Size = new Size(91, 99);
            HexLabel.TabIndex = 2;
            HexLabel.Text = "Hexadezimal:";
            HexLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OctalLabel
            // 
            OctalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            OctalLabel.AutoSize = true;
            OctalLabel.Font = new Font("Consolas", 9F);
            OctalLabel.Location = new Point(3, 297);
            OctalLabel.Name = "OctalLabel";
            OctalLabel.Size = new Size(49, 101);
            OctalLabel.TabIndex = 3;
            OctalLabel.Text = "Oktal:";
            OctalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DecimalTextBoxExt
            // 
            DecimalTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DecimalTextBoxExt.BeforeTouchSize = new Size(409, 93);
            DecimalTextBoxExt.Font = new Font("Consolas", 9F);
            DecimalTextBoxExt.Location = new Point(100, 3);
            DecimalTextBoxExt.Multiline = true;
            DecimalTextBoxExt.Name = "DecimalTextBoxExt";
            DecimalTextBoxExt.Size = new Size(409, 93);
            DecimalTextBoxExt.TabIndex = 4;
            DecimalTextBoxExt.ThemesEnabled = false;
            DecimalTextBoxExt.TextChanged += InputTextBoxExts_TextChanged;
            DecimalTextBoxExt.KeyDown += InputTextBoxExts_KeyDown;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(518, 404);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ausführlich";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // NumericSystemsConversionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NumericSystemsConversionToolsTabControl);
            Name = "NumericSystemsConversionControl";
            Size = new Size(526, 432);
            NumericSystemsConversionToolsTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            SimpleNumericSystemsConversionTableLayoutPanel.ResumeLayout(false);
            SimpleNumericSystemsConversionTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OctalTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)HexTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinaryTextBoxExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)DecimalTextBoxExt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl NumericSystemsConversionToolsTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel SimpleNumericSystemsConversionTableLayoutPanel;
        private Label DecimalLabel;
        private Label BinaryLabel;
        private Label HexLabel;
        private Label OctalLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DecimalTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt OctalTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt HexTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt BinaryTextBoxExt;
    }
}
