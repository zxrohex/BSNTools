namespace BSNTools.UI.Controls
{
    partial class AboutControl
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
            AboutLogoPictureBox = new PictureBox();
            AboutTitleLabel = new Label();
            AboutDescLabel = new Label();
            AboutVersionLabel = new Label();
            AboutAuthorLabel = new Label();
            DetailedInfoTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)AboutLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DetailedInfoTextBoxExt).BeginInit();
            SuspendLayout();
            // 
            // AboutLogoPictureBox
            // 
            AboutLogoPictureBox.BackColor = Color.White;
            AboutLogoPictureBox.BorderStyle = BorderStyle.Fixed3D;
            AboutLogoPictureBox.Image = Properties.Resources.BSNToolsLogoNoBG;
            AboutLogoPictureBox.Location = new Point(17, 14);
            AboutLogoPictureBox.Name = "AboutLogoPictureBox";
            AboutLogoPictureBox.Size = new Size(116, 107);
            AboutLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AboutLogoPictureBox.TabIndex = 0;
            AboutLogoPictureBox.TabStop = false;
            // 
            // AboutTitleLabel
            // 
            AboutTitleLabel.AutoSize = true;
            AboutTitleLabel.Font = new Font("Consolas", 18F, FontStyle.Bold);
            AboutTitleLabel.Location = new Point(139, 14);
            AboutTitleLabel.Name = "AboutTitleLabel";
            AboutTitleLabel.Size = new Size(129, 28);
            AboutTitleLabel.TabIndex = 1;
            AboutTitleLabel.Text = "BSN-Tools";
            // 
            // AboutDescLabel
            // 
            AboutDescLabel.AutoSize = true;
            AboutDescLabel.Font = new Font("Consolas", 9F);
            AboutDescLabel.Location = new Point(142, 46);
            AboutDescLabel.Name = "AboutDescLabel";
            AboutDescLabel.Size = new Size(203, 14);
            AboutDescLabel.TabIndex = 2;
            AboutDescLabel.Text = "Tools für den BSN-Unterricht";
            // 
            // AboutVersionLabel
            // 
            AboutVersionLabel.AutoSize = true;
            AboutVersionLabel.Font = new Font("Consolas", 9F);
            AboutVersionLabel.Location = new Point(142, 106);
            AboutVersionLabel.Name = "AboutVersionLabel";
            AboutVersionLabel.Size = new Size(84, 14);
            AboutVersionLabel.TabIndex = 3;
            AboutVersionLabel.Text = "Version %%%";
            // 
            // AboutAuthorLabel
            // 
            AboutAuthorLabel.AutoSize = true;
            AboutAuthorLabel.Font = new Font("Consolas", 9F);
            AboutAuthorLabel.Location = new Point(142, 76);
            AboutAuthorLabel.Name = "AboutAuthorLabel";
            AboutAuthorLabel.Size = new Size(273, 14);
            AboutAuthorLabel.TabIndex = 8;
            AboutAuthorLabel.Text = "Erstellt von Sasha/Lynn (aka memalloc)";
            // 
            // DetailedInfoTextBoxExt
            // 
            DetailedInfoTextBoxExt.AcceptsReturn = true;
            DetailedInfoTextBoxExt.BeforeTouchSize = new Size(654, 250);
            DetailedInfoTextBoxExt.Font = new Font("Consolas", 9F);
            DetailedInfoTextBoxExt.Location = new Point(17, 128);
            DetailedInfoTextBoxExt.Multiline = true;
            DetailedInfoTextBoxExt.Name = "DetailedInfoTextBoxExt";
            DetailedInfoTextBoxExt.ReadOnly = true;
            DetailedInfoTextBoxExt.Size = new Size(654, 250);
            DetailedInfoTextBoxExt.TabIndex = 9;
            DetailedInfoTextBoxExt.ThemesEnabled = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(17, 386);
            button1.Name = "button1";
            button1.Size = new Size(186, 33);
            button1.TabIndex = 10;
            button1.Text = "GitHub-Repository";
            button1.UseVisualStyleBackColor = true;
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(DetailedInfoTextBoxExt);
            Controls.Add(AboutAuthorLabel);
            Controls.Add(AboutVersionLabel);
            Controls.Add(AboutDescLabel);
            Controls.Add(AboutTitleLabel);
            Controls.Add(AboutLogoPictureBox);
            Name = "AboutControl";
            Size = new Size(689, 432);
            ((System.ComponentModel.ISupportInitialize)AboutLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DetailedInfoTextBoxExt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AboutLogoPictureBox;
        private Label AboutTitleLabel;
        private Label AboutDescLabel;
        private Label AboutVersionLabel;
        private Label AboutAuthorLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DetailedInfoTextBoxExt;
        private Button button1;
    }
}
