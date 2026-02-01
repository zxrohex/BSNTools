namespace BSNTools.UI.Controls
{
    partial class UnitConversionControl
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
            CommonUnitsConverterGroupBox = new GroupBox();
            UnitConversionMathExplainerTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            UnitConversionInputsPanel = new Panel();
            SecondUnitComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            AreLabel = new Label();
            FirstUnitComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            SecondUnitNumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            FirstUnitNumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            TransferTimeCalculationGroupBox = new GroupBox();
            TransferCalculationResultLabel = new Label();
            TransferSecondUnitComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            TransferSecondUnitNumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            TransferAreLabel = new Label();
            TransferFirstUnitComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            TransferFirstUnitNumericUpDownExt = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            CommonUnitsConverterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UnitConversionMathExplainerTextBoxExt).BeginInit();
            UnitConversionInputsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SecondUnitComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstUnitComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondUnitNumericUpDownExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstUnitNumericUpDownExt).BeginInit();
            TransferTimeCalculationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransferSecondUnitComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferSecondUnitNumericUpDownExt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferFirstUnitComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransferFirstUnitNumericUpDownExt).BeginInit();
            SuspendLayout();
            // 
            // CommonUnitsConverterGroupBox
            // 
            CommonUnitsConverterGroupBox.Controls.Add(UnitConversionMathExplainerTextBoxExt);
            CommonUnitsConverterGroupBox.Controls.Add(UnitConversionInputsPanel);
            CommonUnitsConverterGroupBox.Dock = DockStyle.Top;
            CommonUnitsConverterGroupBox.Location = new Point(8, 8);
            CommonUnitsConverterGroupBox.Name = "CommonUnitsConverterGroupBox";
            CommonUnitsConverterGroupBox.Padding = new Padding(3, 3, 3, 4);
            CommonUnitsConverterGroupBox.Size = new Size(510, 136);
            CommonUnitsConverterGroupBox.TabIndex = 0;
            CommonUnitsConverterGroupBox.TabStop = false;
            CommonUnitsConverterGroupBox.Text = "Umrechnen";
            // 
            // UnitConversionMathExplainerTextBoxExt
            // 
            UnitConversionMathExplainerTextBoxExt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UnitConversionMathExplainerTextBoxExt.BeforeTouchSize = new Size(100, 23);
            UnitConversionMathExplainerTextBoxExt.Location = new Point(17, 61);
            UnitConversionMathExplainerTextBoxExt.Multiline = true;
            UnitConversionMathExplainerTextBoxExt.Name = "UnitConversionMathExplainerTextBoxExt";
            UnitConversionMathExplainerTextBoxExt.ReadOnly = true;
            UnitConversionMathExplainerTextBoxExt.Size = new Size(476, 62);
            UnitConversionMathExplainerTextBoxExt.TabIndex = 0;
            UnitConversionMathExplainerTextBoxExt.ThemesEnabled = false;
            // 
            // UnitConversionInputsPanel
            // 
            UnitConversionInputsPanel.Controls.Add(SecondUnitComboBoxAdv);
            UnitConversionInputsPanel.Controls.Add(AreLabel);
            UnitConversionInputsPanel.Controls.Add(FirstUnitComboBoxAdv);
            UnitConversionInputsPanel.Controls.Add(SecondUnitNumericUpDownExt);
            UnitConversionInputsPanel.Controls.Add(FirstUnitNumericUpDownExt);
            UnitConversionInputsPanel.Dock = DockStyle.Top;
            UnitConversionInputsPanel.Location = new Point(3, 19);
            UnitConversionInputsPanel.MinimumSize = new Size(504, 40);
            UnitConversionInputsPanel.Name = "UnitConversionInputsPanel";
            UnitConversionInputsPanel.Size = new Size(504, 40);
            UnitConversionInputsPanel.TabIndex = 0;
            // 
            // SecondUnitComboBoxAdv
            // 
            SecondUnitComboBoxAdv.AllowNewText = false;
            SecondUnitComboBoxAdv.Anchor = AnchorStyles.None;
            SecondUnitComboBoxAdv.DropDownStyle = ComboBoxStyle.DropDownList;
            SecondUnitComboBoxAdv.Height = 23;
            SecondUnitComboBoxAdv.Location = new Point(394, 9);
            SecondUnitComboBoxAdv.Name = "SecondUnitComboBoxAdv";
            SecondUnitComboBoxAdv.Size = new Size(96, 23);
            SecondUnitComboBoxAdv.TabIndex = 3;
            SecondUnitComboBoxAdv.TextBoxHeight = 23;
            SecondUnitComboBoxAdv.SelectedIndexChanged += UnitComboBoxAdvs_SelectedIndexChanged;
            // 
            // AreLabel
            // 
            AreLabel.Anchor = AnchorStyles.None;
            AreLabel.AutoSize = true;
            AreLabel.Location = new Point(237, 12);
            AreLabel.Name = "AreLabel";
            AreLabel.Size = new Size(29, 15);
            AreLabel.TabIndex = 4;
            AreLabel.Text = "sind";
            // 
            // FirstUnitComboBoxAdv
            // 
            FirstUnitComboBoxAdv.AllowNewText = false;
            FirstUnitComboBoxAdv.Anchor = AnchorStyles.None;
            FirstUnitComboBoxAdv.DropDownStyle = ComboBoxStyle.DropDownList;
            FirstUnitComboBoxAdv.Height = 23;
            FirstUnitComboBoxAdv.Location = new Point(137, 9);
            FirstUnitComboBoxAdv.Name = "FirstUnitComboBoxAdv";
            FirstUnitComboBoxAdv.Size = new Size(96, 23);
            FirstUnitComboBoxAdv.TabIndex = 1;
            FirstUnitComboBoxAdv.TextBoxHeight = 23;
            FirstUnitComboBoxAdv.SelectedIndexChanged += UnitComboBoxAdvs_SelectedIndexChanged;
            // 
            // SecondUnitNumericUpDownExt
            // 
            SecondUnitNumericUpDownExt.Anchor = AnchorStyles.None;
            SecondUnitNumericUpDownExt.BeforeTouchSize = new Size(117, 23);
            SecondUnitNumericUpDownExt.Location = new Point(271, 9);
            SecondUnitNumericUpDownExt.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            SecondUnitNumericUpDownExt.MaxLength = 999999999;
            SecondUnitNumericUpDownExt.Name = "SecondUnitNumericUpDownExt";
            SecondUnitNumericUpDownExt.Size = new Size(117, 23);
            SecondUnitNumericUpDownExt.TabIndex = 2;
            SecondUnitNumericUpDownExt.ValueChanged += UnitNumericUpDownExts_ValueChanged;
            // 
            // FirstUnitNumericUpDownExt
            // 
            FirstUnitNumericUpDownExt.Anchor = AnchorStyles.None;
            FirstUnitNumericUpDownExt.BeforeTouchSize = new Size(117, 23);
            FirstUnitNumericUpDownExt.Location = new Point(14, 9);
            FirstUnitNumericUpDownExt.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            FirstUnitNumericUpDownExt.MaxLength = 999999999;
            FirstUnitNumericUpDownExt.Name = "FirstUnitNumericUpDownExt";
            FirstUnitNumericUpDownExt.Size = new Size(117, 23);
            FirstUnitNumericUpDownExt.TabIndex = 0;
            FirstUnitNumericUpDownExt.ValueChanged += UnitNumericUpDownExts_ValueChanged;
            // 
            // TransferTimeCalculationGroupBox
            // 
            TransferTimeCalculationGroupBox.Controls.Add(TransferCalculationResultLabel);
            TransferTimeCalculationGroupBox.Controls.Add(TransferSecondUnitComboBoxAdv);
            TransferTimeCalculationGroupBox.Controls.Add(TransferSecondUnitNumericUpDownExt);
            TransferTimeCalculationGroupBox.Controls.Add(TransferAreLabel);
            TransferTimeCalculationGroupBox.Controls.Add(TransferFirstUnitComboBoxAdv);
            TransferTimeCalculationGroupBox.Controls.Add(TransferFirstUnitNumericUpDownExt);
            TransferTimeCalculationGroupBox.Location = new Point(8, 150);
            TransferTimeCalculationGroupBox.Name = "TransferTimeCalculationGroupBox";
            TransferTimeCalculationGroupBox.Size = new Size(510, 118);
            TransferTimeCalculationGroupBox.TabIndex = 1;
            TransferTimeCalculationGroupBox.TabStop = false;
            TransferTimeCalculationGroupBox.Text = "Zeit-Berechner";
            // 
            // TransferCalculationResultLabel
            // 
            TransferCalculationResultLabel.BorderStyle = BorderStyle.Fixed3D;
            TransferCalculationResultLabel.Location = new Point(17, 62);
            TransferCalculationResultLabel.Name = "TransferCalculationResultLabel";
            TransferCalculationResultLabel.Size = new Size(476, 42);
            TransferCalculationResultLabel.TabIndex = 6;
            TransferCalculationResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransferSecondUnitComboBoxAdv
            // 
            TransferSecondUnitComboBoxAdv.AllowNewText = false;
            TransferSecondUnitComboBoxAdv.Anchor = AnchorStyles.None;
            TransferSecondUnitComboBoxAdv.DropDownStyle = ComboBoxStyle.DropDownList;
            TransferSecondUnitComboBoxAdv.Height = 23;
            TransferSecondUnitComboBoxAdv.Location = new Point(397, 26);
            TransferSecondUnitComboBoxAdv.Name = "TransferSecondUnitComboBoxAdv";
            TransferSecondUnitComboBoxAdv.Size = new Size(96, 23);
            TransferSecondUnitComboBoxAdv.TabIndex = 5;
            TransferSecondUnitComboBoxAdv.TextBoxHeight = 23;
            TransferSecondUnitComboBoxAdv.SelectedIndexChanged += TransferUnitComboBoxAdvs_SelectedIndexChanged;
            // 
            // TransferSecondUnitNumericUpDownExt
            // 
            TransferSecondUnitNumericUpDownExt.Anchor = AnchorStyles.None;
            TransferSecondUnitNumericUpDownExt.BeforeTouchSize = new Size(117, 23);
            TransferSecondUnitNumericUpDownExt.Location = new Point(274, 26);
            TransferSecondUnitNumericUpDownExt.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            TransferSecondUnitNumericUpDownExt.MaxLength = 999999999;
            TransferSecondUnitNumericUpDownExt.Name = "TransferSecondUnitNumericUpDownExt";
            TransferSecondUnitNumericUpDownExt.Size = new Size(117, 23);
            TransferSecondUnitNumericUpDownExt.TabIndex = 4;
            TransferSecondUnitNumericUpDownExt.ValueChanged += TransferUnitNumericUpDownExts_ValueChanged;
            // 
            // TransferAreLabel
            // 
            TransferAreLabel.AutoSize = true;
            TransferAreLabel.Location = new Point(243, 29);
            TransferAreLabel.Name = "TransferAreLabel";
            TransferAreLabel.Size = new Size(23, 15);
            TransferAreLabel.TabIndex = 3;
            TransferAreLabel.Text = "bei";
            // 
            // TransferFirstUnitComboBoxAdv
            // 
            TransferFirstUnitComboBoxAdv.AllowNewText = false;
            TransferFirstUnitComboBoxAdv.Anchor = AnchorStyles.None;
            TransferFirstUnitComboBoxAdv.DropDownStyle = ComboBoxStyle.DropDownList;
            TransferFirstUnitComboBoxAdv.Height = 23;
            TransferFirstUnitComboBoxAdv.Location = new Point(140, 26);
            TransferFirstUnitComboBoxAdv.Name = "TransferFirstUnitComboBoxAdv";
            TransferFirstUnitComboBoxAdv.Size = new Size(96, 23);
            TransferFirstUnitComboBoxAdv.TabIndex = 2;
            TransferFirstUnitComboBoxAdv.TextBoxHeight = 23;
            TransferFirstUnitComboBoxAdv.SelectedIndexChanged += TransferUnitComboBoxAdvs_SelectedIndexChanged;
            // 
            // TransferFirstUnitNumericUpDownExt
            // 
            TransferFirstUnitNumericUpDownExt.Anchor = AnchorStyles.None;
            TransferFirstUnitNumericUpDownExt.BeforeTouchSize = new Size(117, 23);
            TransferFirstUnitNumericUpDownExt.Location = new Point(17, 26);
            TransferFirstUnitNumericUpDownExt.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            TransferFirstUnitNumericUpDownExt.MaxLength = 999999999;
            TransferFirstUnitNumericUpDownExt.Name = "TransferFirstUnitNumericUpDownExt";
            TransferFirstUnitNumericUpDownExt.Size = new Size(117, 23);
            TransferFirstUnitNumericUpDownExt.TabIndex = 1;
            TransferFirstUnitNumericUpDownExt.ValueChanged += TransferUnitNumericUpDownExts_ValueChanged;
            // 
            // UnitConversionControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(TransferTimeCalculationGroupBox);
            Controls.Add(CommonUnitsConverterGroupBox);
            Name = "UnitConversionControl";
            Padding = new Padding(8);
            Size = new Size(526, 432);
            CommonUnitsConverterGroupBox.ResumeLayout(false);
            CommonUnitsConverterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UnitConversionMathExplainerTextBoxExt).EndInit();
            UnitConversionInputsPanel.ResumeLayout(false);
            UnitConversionInputsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SecondUnitComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstUnitComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondUnitNumericUpDownExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstUnitNumericUpDownExt).EndInit();
            TransferTimeCalculationGroupBox.ResumeLayout(false);
            TransferTimeCalculationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransferSecondUnitComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferSecondUnitNumericUpDownExt).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferFirstUnitComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransferFirstUnitNumericUpDownExt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CommonUnitsConverterGroupBox;
        private Label AreLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv SecondUnitComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt SecondUnitNumericUpDownExt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv FirstUnitComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt FirstUnitNumericUpDownExt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UnitConversionMathExplainerTextBoxExt;
        private Panel UnitConversionInputsPanel;
        private GroupBox TransferTimeCalculationGroupBox;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv TransferSecondUnitComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt TransferSecondUnitNumericUpDownExt;
        private Label TransferAreLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv TransferFirstUnitComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt TransferFirstUnitNumericUpDownExt;
        private Label TransferCalculationResultLabel;
    }
}
