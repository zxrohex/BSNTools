using BSNTools.Core.IP;
using BSNTools.Core.Conversion;

using System.Diagnostics;
using System.Net;
using System.Reflection;

using UnitsNet;
using UnitsNet.Units;
using System.Runtime.CompilerServices;
using BSNTools.UI.Controls;

namespace BSNTools
{
    public partial class MainForm : Form
    {
        IPInfoControl ipInfoControl;

        NumericSystemsConversionControl numericSystemsConversionControl;

        UnitConversionControl unitConversionControl;

        AboutControl aboutControl;


        Version version = Assembly.GetExecutingAssembly().GetName().Version;

        public MainForm()
        {
            InitializeComponent();

            this.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.F8)
                {
                    ToggleIPInfoControlDisplay(1);
                }
                else if (e.KeyCode == Keys.F4)
                {
                    ToggleIPInfoControlDisplay(0);
                }
            };

            numericSystemsConversionControl = new NumericSystemsConversionControl()
            {
                Dock = DockStyle.Fill
            };

            unitConversionControl = new UnitConversionControl()
            {
                Dock = DockStyle.Fill
            };

            aboutControl = new AboutControl()
            {
                Dock = DockStyle.Fill
            };

            AboutTabPage.Controls.Add(aboutControl);

            VersionLabel.Text = $"Version {version.Major}.{version.Minor}.{version.Build}-prealpha Build {version.Revision}";

            SetUnitAndConversionsTool(0);
        }

        private void SetUnitAndConversionsTool(int index)
        {
            ConversionCalculationToolContainerPanel.Controls.Clear();

            switch (index)
            {
                case 0:
                    ConversionCalculationToolContainerPanel.Controls.Add(numericSystemsConversionControl);
                    break;

                case 1:
                    ConversionCalculationToolContainerPanel.Controls.Add(unitConversionControl);
                    break;

                default:
                    break;
            }
        }

        private void IPCalculateButton_Click(object sender, EventArgs e)
        {
            if (ipInfoControl != null)
            {
                IPCalculationToolsSplitContainer.Panel1.Controls.Remove(ipInfoControl);

                ipInfoControl.Dispose();

                ipInfoControl = null;

                IPCalculationToolsSplitContainer.Panel2.Enabled = false;
            }

            if (!string.IsNullOrEmpty(IPAddressInputTextBox.Text))
            {
                if (!string.IsNullOrEmpty(IPSubnetCIDRInputTextBox.Text))
                {
                    ipInfoControl = new IPInfoControl(IPAddressInputTextBox.Text, byte.Parse(IPSubnetCIDRInputTextBox.Text))
                    {
                        Dock = DockStyle.Fill
                    };

                }
                else
                {
                    ipInfoControl = new IPInfoControl(IPAddressInputTextBox.Text)
                    {
                        Dock = DockStyle.Fill
                    };
                }

                IPCalculationToolsSplitContainer.Panel1.Controls.Add(ipInfoControl);

                IPCalculationToolsSplitContainer.Panel2.Enabled = true;
            }


        }

        private void IPInputTextBoxes_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(IPAddressInputTextBox.Text))
            {
                try
                {
                    if (!string.IsNullOrEmpty(IPSubnetCIDRInputTextBox.Text))
                    {
                        IPInputsCalcStatsLabel.Text = $"{IPTools.GetSubnetCount(IPAddressInputTextBox.Text, byte.Parse(IPSubnetCIDRInputTextBox.Text))}" +
                            $" * {IPTools.GetAddressesCountPerSubnet(IPAddressInputTextBox.Text, byte.Parse(IPSubnetCIDRInputTextBox.Text))} Adressen";
                    }
                    else
                    {
                        IPInputsCalcStatsLabel.Text = $"{IPTools.GetAddressesTotalCount(IPAddressInputTextBox.Text)} Adressen";
                    }

                    IPCalculateButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is ArgumentOutOfRangeException || ex is ArgumentException || ex is OverflowException)
                    {
                        IPInputsCalcStatsLabel.Text = "Ungültige Eingabe";
                    }
                    else
                    {
                        IPInputsCalcStatsLabel.Text = "Unbekannter Fehler";
                    }

                    IPCalculateButton.Enabled = false;
                }
            }
            else
            {
                IPInputsCalcStatsLabel.Text = "";

                IPCalculateButton.Enabled = false;
            }
        }

        private void ConversionCalculationToolsMenu_GroupViewItemSelected(object sender, EventArgs e)
        {
            SetUnitAndConversionsTool(ConversionCalculationToolsMenu.SelectedItem);
        }

        private void ToggleIPInfoControlDisplay(int viewType)
        {
            if (ipInfoControl != null)
            {
                switch (viewType)
                {
                    case 0:
                        if (ipInfoControl.BitFormEnabled)
                        {
                            BitFormToggleButton.Text = "Bitform:\nAus";

                        }
                        else
                        {
                            BitFormToggleButton.Text = "Bitform:\nAn";
                        }

                        ipInfoControl.ToggleNetmaskBitforms();
                        break;

                    case 1:
                        if (ipInfoControl.WildcardMaskEnabled)
                        {
                            WildcardMaskToggleButton.Text = "Wildcard-Maske:\nAus";
                        }
                        else
                        {
                            WildcardMaskToggleButton.Text = "Wildcard-Maske:\nAn";
                        }
                        ipInfoControl?.ToggleWildcardMask();
                        break;
                }
            }
        }


        private void BitFormToggleButton_Click(object sender, EventArgs e)
        {
            ToggleIPInfoControlDisplay(0);
        }

        private void WildcardMaskToggleButton_Click(object sender, EventArgs e)
        {
            ToggleIPInfoControlDisplay(1);



        }

        private void AdvancedViewButton_Click(object sender, EventArgs e)
        {
            if (ipInfoControl != null)
            {

                using (AdvancedIPToolsForm advancedIPToolsForm = new AdvancedIPToolsForm(ipInfoControl))
                {
                    advancedIPToolsForm.ShowDialog();
                }

            }
        }
    }
}
