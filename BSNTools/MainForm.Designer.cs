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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BorderLabel = new Label();
            MainTabControl = new TabControl();
            tabPage1 = new TabPage();
            OctetGroupBox = new GroupBox();
            OctetTextBox = new TextBox();
            HexGroupBox = new GroupBox();
            HexNumericUpDown = new NumericUpDown();
            BinaryGroupBox = new GroupBox();
            BinaryTextBox = new TextBox();
            DecimalGroupBox = new GroupBox();
            DecimalNumericUpDown = new NumericUpDown();
            tabPage2 = new TabPage();
            IPAddressInputGroupBox = new GroupBox();
            IPAddressInputTextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
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
            IPAddressInputGroupBox.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 52);
            label2.Name = "label2";
            label2.Size = new Size(278, 30);
            label2.TabIndex = 2;
            label2.Text = "Tools für den BSN-Unterricht";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BSNToolsLogo;
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // OctetTextBox
            // 
            OctetTextBox.Dock = DockStyle.Fill;
            OctetTextBox.Location = new Point(22, 50);
            OctetTextBox.Name = "OctetTextBox";
            OctetTextBox.Size = new Size(1013, 35);
            OctetTextBox.TabIndex = 1;
            OctetTextBox.TextAlign = HorizontalAlignment.Center;
            OctetTextBox.TextChanged += OctetTextBox_TextChanged;
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
            // HexNumericUpDown
            // 
            HexNumericUpDown.Dock = DockStyle.Fill;
            HexNumericUpDown.Hexadecimal = true;
            HexNumericUpDown.Location = new Point(22, 50);
            HexNumericUpDown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            HexNumericUpDown.Name = "HexNumericUpDown";
            HexNumericUpDown.Size = new Size(1013, 35);
            HexNumericUpDown.TabIndex = 1;
            HexNumericUpDown.TextAlign = HorizontalAlignment.Center;
            HexNumericUpDown.ValueChanged += HexNumericUpDown_ValueChanged;
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
            // BinaryTextBox
            // 
            BinaryTextBox.Dock = DockStyle.Fill;
            BinaryTextBox.Location = new Point(22, 50);
            BinaryTextBox.Name = "BinaryTextBox";
            BinaryTextBox.Size = new Size(1013, 35);
            BinaryTextBox.TabIndex = 0;
            BinaryTextBox.TextAlign = HorizontalAlignment.Center;
            BinaryTextBox.TextChanged += BinaryTextBox_TextChanged;
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
            // DecimalNumericUpDown
            // 
            DecimalNumericUpDown.Dock = DockStyle.Fill;
            DecimalNumericUpDown.Location = new Point(22, 50);
            DecimalNumericUpDown.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            DecimalNumericUpDown.Name = "DecimalNumericUpDown";
            DecimalNumericUpDown.Size = new Size(1013, 35);
            DecimalNumericUpDown.TabIndex = 0;
            DecimalNumericUpDown.TextAlign = HorizontalAlignment.Center;
            DecimalNumericUpDown.ValueChanged += DecimalNumericUpDown_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(IPAddressInputGroupBox);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1089, 522);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IP/Netzwerke";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // IPAddressInputGroupBox
            // 
            IPAddressInputGroupBox.Controls.Add(IPAddressInputTextBox);
            IPAddressInputGroupBox.Location = new Point(16, 18);
            IPAddressInputGroupBox.Name = "IPAddressInputGroupBox";
            IPAddressInputGroupBox.Padding = new Padding(22, 22, 22, 18);
            IPAddressInputGroupBox.Size = new Size(1057, 117);
            IPAddressInputGroupBox.TabIndex = 0;
            IPAddressInputGroupBox.TabStop = false;
            IPAddressInputGroupBox.Text = "IP-Addresse/CIDR";
            // 
            // IPAddressInputTextBox
            // 
            IPAddressInputTextBox.Dock = DockStyle.Fill;
            IPAddressInputTextBox.Location = new Point(22, 50);
            IPAddressInputTextBox.Name = "IPAddressInputTextBox";
            IPAddressInputTextBox.Size = new Size(1013, 35);
            IPAddressInputTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(16, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(373, 141);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(731, 141);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
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
            OctetGroupBox.ResumeLayout(false);
            OctetGroupBox.PerformLayout();
            HexGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HexNumericUpDown).EndInit();
            BinaryGroupBox.ResumeLayout(false);
            BinaryGroupBox.PerformLayout();
            DecimalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DecimalNumericUpDown).EndInit();
            tabPage2.ResumeLayout(false);
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
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}
