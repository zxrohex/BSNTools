using BSNTools.Core.IP;
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
                IPAddressTextBox.Text = IPNet.GetIPWithoutCIDR(IPAddressInputTextBox.Text);
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
            try 
            {
                ipNetwork = IPNetwork2.Parse(IPAddressInputTextBox.Text);
                UpdateNetworkInfo();
            }
            catch
            {
                // Ignore invalid input
            }
        }

        private void DecimalGroupBox_Enter(object sender, EventArgs e)
        {
            ConversionInfoLabel.Text = "Dezimal (Basis 10) ist das gebräuchlichste Zahlensystem, das die Ziffern 0-9 verwendet und in alltäglichen Anwendungen weit verbreitet ist.";
        }

        private void BinaryGroupBox_Enter(object sender, EventArgs e)
        {
            ConversionInfoLabel.Text = "Binär (Basis 2) ist ein Zahlensystem, das nur die Ziffern 0 und 1 verwendet und in der digitalen Elektronik und Computertechnik weit verbreitet ist.";
        }

        private void HexGroupBox_Enter(object sender, EventArgs e)
        {
            ConversionInfoLabel.Text = "Hexadezimal (Basis 16) ist ein Zahlensystem, das sechzehn Symbole verwendet: die Ziffern 0-9 und die Buchstaben A-F, und wird häufig in der Informatik zur Darstellung von Binärdaten verwendet.";
        }

        private void OctetGroupBox_Enter(object sender, EventArgs e)
        {
            ConversionInfoLabel.Text = "Oktett (Basis 8) ist ein Zahlensystem, das die Ziffern 0-7 verwendet und in bestimmten Computeranwendungen und älteren Computersystemen verwendet wird.";
        }

        private void DecimalGroupBox_Leave(object sender, EventArgs e)
        {
            ConversionInfoLabel.Text = "";
        }

        private void IPAddressInputGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Geben Sie eine IP-Adresse ein, um detaillierte Netzwerkinformationen wie CIDR, Subnetzmaske, Netzwerkadresse, Broadcast-Adresse und nutzbare Adressen zu erhalten.";
        }

        private void IPAddressGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die IP-Adresse identifiziert ein Gerät in einem Netzwerk eindeutig und ermöglicht die Kommunikation zwischen verschiedenen Geräten.";
        }

        private void CIDRGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "CIDR (Classless Inter-Domain Routing) ist eine Methode zur Zuweisung von IP-Adressen und zur effizienteren Nutzung von IP-Adressräumen durch Angabe der Netzwerklänge in Bits.";
        }

        private void SubnetmaskGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die Subnetzmaske teilt eine IP-Adresse in Netzwerk- und Hostanteile auf und bestimmt, welche Teile der Adresse das Netzwerk und welche Teile die Geräte innerhalb dieses Netzwerks identifizieren.";
        }

        private void NetworkAddressGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die Netzwerkadresse repräsentiert das gesamte Netzwerksegment und wird verwendet, um Geräte innerhalb desselben Netzwerks zu identifizieren.";
        }

        private void BroadcastAddressGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die Broadcast-Adresse wird verwendet, um Nachrichten an alle Geräte in einem Netzwerksegment zu senden und ermöglicht die Kommunikation mit allen Hosts gleichzeitig.";
        }

        private void UsableAddressesGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Nutzbare Adressen sind die IP-Adressen innerhalb eines Netzwerks, die Geräten zugewiesen werden können, abzüglich der Netzwerk- und Broadcast-Adressen.";
        }

        private void FirstUsableAddressGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die erste nutzbare Adresse ist die erste IP-Adresse in einem Subnetz, die einem Gerät zugewiesen werden kann, nachdem die Netzwerkadresse berücksichtigt wurde.";
        }

        private void LastUsableAddressGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die letzte nutzbare Adresse ist die letzte IP-Adresse in einem Subnetz, die einem Gerät zugewiesen werden kann, bevor die Broadcast-Adresse erreicht wird.";
        }

        private void TotalAddressesGroupBox_Enter(object sender, EventArgs e)
        {
            IPNetworkInfoLabel.Text = "Die Gesamtanzahl der Adressen in einem Subnetz umfasst alle möglichen IP-Adressen, einschließlich der Netzwerk- und Broadcast-Adressen.";
        }
    }
}
