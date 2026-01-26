using BSNTools.Core.IP;

using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace BSNTools
{
    public partial class MainForm : Form
    {
        int decimalNumber = 0;

        IPNetwork2 ipNetwork;

        public MainForm()
        {
            InitializeComponent();

            InitializeVersionLabels();

            RandomizeAboutDescriptionQuotes();

            LoadUnitsIntoComboBoxes();
        }

        private void InitializeVersionLabels()
        {
            VersionLabel.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version}";

            AboutVersionLabel.Text = $"Version {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void LoadUnitsIntoComboBoxes()
        {
            var units = Enum.GetValues(typeof(Core.Conversion.Unit)).Cast<Core.Conversion.Unit>();

            foreach (var unit in units)
            {
                ConversionOneComboBox.Items.Add(unit.ToString());
                ConversionTwoComboBox.Items.Add(unit.ToString());
                ConversionThreeComboBox.Items.Add(unit.ToString());
            }

            ConversionOneComboBox.SelectedIndex = 0;
            ConversionTwoComboBox.SelectedIndex = 1;
            ConversionThreeComboBox.SelectedIndex = 2;
        }

        private void RandomizeAboutDescriptionQuotes()
        {
            int rng = Random.Shared.Next(0, 4);

            switch (rng)
            {
                case 0:
                    AboutDescriptionLabel.Text = "Automatisierte Berechnungen & Lernhilfen für das Fach Betriebssysteme und Netzwerke.";
                    break;

                case 1:
                    AboutDescriptionLabel.Text = "BSN Tools: Dein Helfer für Netzwerktechnik und Zahlensysteme im ITA-Fachabi.";
                    break;

                default:
                case 2:
                    AboutDescriptionLabel.Text = "Automatisierte Berechnungen & Lernhilfen für das Fach Betriebssysteme und Netzwerke.";
                    break;

                case 3:
                    AboutDescriptionLabel.Text = "Hilfsprogramme für BSN: Berechne Netzwerke und Zahlensysteme effizient (ITA-Fachabi)";
                    break;

                case 4:
                    AboutDescriptionLabel.Text = "BSN-Tools (ITA): Netzwerk- & Zahlensystem-Berechnungen einfach automatisiert.";
                    break;
            }
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

        private void UpdateInfoLabel(int infoLabelType, string text)
        {
            switch (infoLabelType)
            {
                case 1:
                    ConversionInfoLabel.Text = text;
                    break;
                case 2:
                    IPNetworkInfoLabel.Text = text;
                    break;
                default:
                    break;
            }
        }

        private void DecimalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimalNumber = (int)DecimalNumericUpDown.Value;

            UpdateConversions();
        }

        private void BinaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimalNumber = Convert.ToInt32(BinaryTextBox.Text, 2);

                UpdateConversions();
            }
            catch (FormatException fex)
            {


            }


        }

        private void HexNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimalNumber = (int)HexNumericUpDown.Value;

            UpdateConversions();
        }

        private void OctetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimalNumber = Convert.ToInt32(OctetTextBox.Text, 8);

                UpdateConversions();
            }
            catch (FormatException fex)
            {


            }


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

            UpdateInfoLabel(1, "Dezimal (Basis 10) ist das am häufigsten verwendete Zahlensystem, das die Ziffern 0-9 verwendet und in alltäglichen Anwendungen wie Finanzen und Messungen weit verbreitet ist.");
        }

        private void BinaryGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(1, "Binär (Basis 2) ist ein Zahlensystem, das nur die Ziffern 0 und 1 verwendet und in der digitalen Elektronik und Computertechnik weit verbreitet ist.");
        }

        private void HexGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(1, "Hexadezimal (Basis 16) ist ein Zahlensystem, das sechzehn Symbole verwendet: die Ziffern 0-9 und die Buchstaben A-F, und wird häufig in der Informatik zur Darstellung von Binärdaten verwendet.");
        }

        private void OctetGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(1, "Oktett (Basis 8) ist ein Zahlensystem, das die Ziffern 0-7 verwendet und in bestimmten Computeranwendungen und älteren Computersystemen verwendet wird.");
        }

        private void ConversionGroupBoxes_Leave(object sender, EventArgs e)
        {
            UpdateInfoLabel(1, "");
        }

        private void IPAddressInputGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Geben Sie eine IP-Adresse ein, um detaillierte Netzwerkinformationen wie CIDR, Subnetzmaske, Netzwerkadresse, Broadcast-Adresse und nutzbare Adressen zu erhalten.");
        }

        private void IPAddressGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die IP-Adresse identifiziert ein Gerät in einem Netzwerk eindeutig und ermöglicht die Kommunikation zwischen verschiedenen Geräten.");
        }

        private void CIDRGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "CIDR (Classless Inter-Domain Routing) ist eine Methode zur Zuweisung von IP-Adressen und zur effizienteren Nutzung von IP-Adressräumen durch Angabe der Netzwerklänge in Bits.");
        }

        private void SubnetmaskGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die Subnetzmaske teilt eine IP-Adresse in Netzwerk- und Hostanteile auf und bestimmt, welche Teile der Adresse das Netzwerk und welche Teile die Geräte innerhalb dieses Netzwerks identifizieren.");
        }

        private void NetworkAddressGroupBox_Enter(object sender, EventArgs e)
        {

            UpdateInfoLabel(2, "Die Netzwerkadresse repräsentiert das gesamte Netzwerksegment und wird verwendet, um Geräte innerhalb desselben Netzwerks zu identifizieren.");
        }

        private void BroadcastAddressGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die Broadcast-Adresse wird verwendet, um Nachrichten an alle Geräte in einem Netzwerksegment zu senden und ermöglicht die Kommunikation mit allen Hosts gleichzeitig.");
        }

        private void UsableAddressesGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Nutzbare Adressen sind die IP-Adressen innerhalb eines Netzwerks, die Geräten zugewiesen werden können, abzüglich der Netzwerk- und Broadcast-Adressen.");
        }

        private void FirstUsableAddressGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die erste nutzbare Adresse ist die erste IP-Adresse in einem Subnetz, die einem Gerät zugewiesen werden kann, nachdem die Netzwerkadresse berücksichtigt wurde.");
        }

        private void LastUsableAddressGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die letzte nutzbare Adresse ist die letzte IP-Adresse in einem Subnetz, die einem Gerät zugewiesen werden kann, bevor die Broadcast-Adresse erreicht wird.");
        }

        private void TotalAddressesGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "Die Gesamtanzahl der Adressen in einem Subnetz umfasst alle möglichen IP-Adressen, einschließlich der Netzwerk- und Broadcast-Adressen.");
        }

        private void IPToolsGroupBoxes_Leave(object sender, EventArgs e)
        {
            UpdateInfoLabel(2, "");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AboutGHRepoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
                ()
            { FileName = "https://github.com/zxrohex/BSNTools", UseShellExecute = true });
        }

        private void ConversionOneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConversionTwoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConversionThreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
