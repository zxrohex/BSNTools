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
            HeaderPanel = new Panel();
            BorderLabel = new Label();
            pictureBox1 = new PictureBox();
            MainTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            DecimalGroupBox = new GroupBox();
            BinaryGroupBox = new GroupBox();
            HexGroupBox = new GroupBox();
            OctetGroupBox = new GroupBox();
            DecimalNumericUpDown = new NumericUpDown();
            HexNumericUpDown = new NumericUpDown();
            BinaryTextBox = new TextBox();
            OctetTextBox = new TextBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            DecimalGroupBox.SuspendLayout();
            BinaryGroupBox.SuspendLayout();
            HexGroupBox.SuspendLayout();
            OctetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DecimalNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HexNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.Controls.Add(label2);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1137, 107);
            HeaderPanel.TabIndex = 0;
            // 
            // BorderLabel
            // 
            BorderLabel.BorderStyle = BorderStyle.Fixed3D;
            BorderLabel.Dock = DockStyle.Top;
            BorderLabel.Location = new Point(0, 107);
            BorderLabel.Name = "BorderLabel";
            BorderLabel.Size = new Size(1137, 2);
            BorderLabel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(tabPage1);
            MainTabControl.Controls.Add(tabPage2);
            MainTabControl.Location = new Point(20, 124);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1097, 565);
            MainTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(OctetGroupBox);
            tabPage1.Controls.Add(HexGroupBox);
            tabPage1.Controls.Add(BinaryGroupBox);
            tabPage1.Controls.Add(DecimalGroupBox);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1089, 522);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Umrechnung";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1089, 522);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IP/Netzwerke";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(109, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 1;
            label1.Text = "BSN Tools";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 52);
            label2.Name = "label2";
            label2.Size = new Size(278, 30);
            label2.TabIndex = 2;
            label2.Text = "Tools für den BSN-Unterricht";
            // 
            // DecimalGroupBox
            // 
            DecimalGroupBox.Controls.Add(DecimalNumericUpDown);
            DecimalGroupBox.Location = new Point(16, 18);
            DecimalGroupBox.Name = "DecimalGroupBox";
            DecimalGroupBox.Padding = new Padding(22, 22, 22, 18);
            DecimalGroupBox.Size = new Size(1057, 117);
            DecimalGroupBox.TabIndex = 0;
            DecimalGroupBox.TabStop = false;
            DecimalGroupBox.Text = "Dezimal";
            // 
            // BinaryGroupBox
            // 
            BinaryGroupBox.Controls.Add(BinaryTextBox);
            BinaryGroupBox.Location = new Point(16, 141);
            BinaryGroupBox.Name = "BinaryGroupBox";
            BinaryGroupBox.Padding = new Padding(22, 22, 22, 18);
            BinaryGroupBox.Size = new Size(1057, 117);
            BinaryGroupBox.TabIndex = 1;
            BinaryGroupBox.TabStop = false;
            BinaryGroupBox.Text = "Binär";
            // 
            // HexGroupBox
            // 
            HexGroupBox.Controls.Add(HexNumericUpDown);
            HexGroupBox.Location = new Point(16, 264);
            HexGroupBox.Name = "HexGroupBox";
            HexGroupBox.Padding = new Padding(22, 22, 22, 18);
            HexGroupBox.Size = new Size(1057, 117);
            HexGroupBox.TabIndex = 2;
            HexGroupBox.TabStop = false;
            HexGroupBox.Text = "Hexadezimal";
            // 
            // OctetGroupBox
            // 
            OctetGroupBox.Controls.Add(OctetTextBox);
            OctetGroupBox.Location = new Point(16, 387);
            OctetGroupBox.Name = "OctetGroupBox";
            OctetGroupBox.Padding = new Padding(22, 22, 22, 18);
            OctetGroupBox.Size = new Size(1057, 117);
            OctetGroupBox.TabIndex = 3;
            OctetGroupBox.TabStop = false;
            OctetGroupBox.Text = "Oktett";
            // 
            // DecimalNumericUpDown
            // 
            DecimalNumericUpDown.Dock = DockStyle.Fill;
            DecimalNumericUpDown.Location = new Point(22, 50);
            DecimalNumericUpDown.Name = "DecimalNumericUpDown";
            DecimalNumericUpDown.Size = new Size(1013, 35);
            DecimalNumericUpDown.TabIndex = 0;
            DecimalNumericUpDown.ValueChanged += DecimalNumericUpDown_ValueChanged;
            // 
            // HexNumericUpDown
            // 
            HexNumericUpDown.Dock = DockStyle.Fill;
            HexNumericUpDown.Hexadecimal = true;
            HexNumericUpDown.Location = new Point(22, 50);
            HexNumericUpDown.Name = "HexNumericUpDown";
            HexNumericUpDown.Size = new Size(1013, 35);
            HexNumericUpDown.TabIndex = 1;
            HexNumericUpDown.ValueChanged += HexNumericUpDown_ValueChanged;
            // 
            // BinaryTextBox
            // 
            BinaryTextBox.Dock = DockStyle.Fill;
            BinaryTextBox.Location = new Point(22, 50);
            BinaryTextBox.Name = "BinaryTextBox";
            BinaryTextBox.Size = new Size(1013, 35);
            BinaryTextBox.TabIndex = 0;
            BinaryTextBox.TextChanged += BinaryTextBox_TextChanged;
            // 
            // OctetTextBox
            // 
            OctetTextBox.Dock = DockStyle.Fill;
            OctetTextBox.Location = new Point(22, 50);
            OctetTextBox.Name = "OctetTextBox";
            OctetTextBox.Size = new Size(1013, 35);
            OctetTextBox.TabIndex = 1;
            OctetTextBox.TextChanged += OctetTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 706);
            Controls.Add(MainTabControl);
            Controls.Add(BorderLabel);
            Controls.Add(HeaderPanel);
            Name = "MainForm";
            Text = "BSN Tools";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            DecimalGroupBox.ResumeLayout(false);
            BinaryGroupBox.ResumeLayout(false);
            BinaryGroupBox.PerformLayout();
            HexGroupBox.ResumeLayout(false);
            OctetGroupBox.ResumeLayout(false);
            OctetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DecimalNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HexNumericUpDown).EndInit();
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
    }
}
