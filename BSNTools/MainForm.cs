namespace BSNTools
{
    public partial class MainForm : Form
    {
        int decimalNumber = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateConversions()
        {
            DecimalNumericUpDown.Value = decimalNumber;
            BinaryTextBox.Text = Convert.ToString(decimalNumber, 2);
            HexNumericUpDown.Value = decimalNumber;
            OctetTextBox.Text = Convert.ToString(decimalNumber, 8);
        }

        private void DecimalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimalNumber = (int)DecimalNumericUpDown.Value;

            UpdateConversions();
        }

        private void BinaryTextBox_TextChanged(object sender, EventArgs e)
        {
            decimalNumber = Convert.ToInt32(BinaryTextBox.Text, 2);

            UpdateConversions();
        }

        private void HexNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimalNumber = (int)HexNumericUpDown.Value;

            UpdateConversions();
        }

        private void OctetTextBox_TextChanged(object sender, EventArgs e)
        {
            decimalNumber = Convert.ToInt32(OctetTextBox.Text, 8);

            UpdateConversions();
        }
    }
}
