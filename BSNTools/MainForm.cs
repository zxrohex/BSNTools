using System.Net;

namespace BSNTools
{
    public partial class MainForm : Form
    {
        int decimalNumber = 0;

        IPNetwork2 ipNetwork;

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

        private void UpdateNetworkInfo()
        {
            if (ipNetwork != null)
            {
                IPAddressTextBox.Text = ipNetwork.ToString();
                CIDRTextBox.Text = ipNetwork.Cidr.ToString();
                NetworkAddressTextBox.Text = ipNetwork.Network.ToString();
                SubnetmaskTextBox.Text = ipNetwork.Netmask.ToString();
                BroadcastAddressTextBox.Text = ipNetwork.Broadcast.ToString();
                FirstUsableAddressTextBox.Text = ipNetwork.FirstUsable.ToString();
                LastUsableAddressTextBox.Text = ipNetwork.LastUsable.ToString();
                UsableAddressesTextBox.Text = ipNetwork.Usable.ToString();
                TotalAddressesTextBox.Text = ipNetwork.Total.ToString();
            }
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

        private void IPAddressInputTextBox_TextChanged(object sender, EventArgs e)
        {
            ipNetwork = IPNetwork2.Parse(IPAddressInputTextBox.Text);

            UpdateNetworkInfo();
        }
    }
}
