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




        Version version = Assembly.GetExecutingAssembly().GetName().Version;

        public MainForm()
        {
            InitializeComponent();

            numericSystemsConversionControl = new NumericSystemsConversionControl()
            {
                Dock = DockStyle.Fill
            };

            unitConversionControl = new UnitConversionControl()
            {
                Dock = DockStyle.Fill
            };

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
    }
}
