using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace BSNTools.UI.Controls
{
    public partial class IPInfoControl : UserControl
    {
        private IPNetwork2 mainIPNetwork;

        private IPNetworkCollection subnets;

        string sourceAddress;

        byte sourceCidr;

        bool bitFormEnabled = false;

        bool wildcardMaskEnabled = false;


        public IPInfoControl(string ipAddress)
        {
            InitializeComponent();

            mainIPNetwork = IPNetwork2.Parse(ipAddress, true);

            sourceAddress = ipAddress;
        }

        public IPInfoControl(string ipAddress, byte subnetCidr) : this(ipAddress)
        {
            subnets = mainIPNetwork.Subnet(subnetCidr);

            sourceCidr = subnetCidr;
        }


        private void InitializeUI()
        {
            if (mainIPNetwork != null)
            {
                IPSourceAddressLabel.Text = mainIPNetwork.ToString();

                IPSubnetsComboBox.Items.Add(mainIPNetwork.ToString());

                if (subnets != null && subnets.Count > 0)
                {
                    foreach (IPNetwork2 subnet in subnets)
                    {
                        IPSubnetsComboBox.Items.Add(subnet.ToString());
                    }

                    IPSubnetsComboBox.Enabled = true;
                }
                else
                {
                    UpdateUI(mainIPNetwork);

                    IPSubnetsComboBox.Enabled = false;
                }

                IPSubnetsComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateUI(IPNetwork2 ipNetwork)
        {
            if (ipNetwork != null)
            {
                IPAddressCIDRTextBoxExt.Text = ipNetwork.ToString();
                IPNetmaskLabel.Text = "Netzmaske:";
                IPNetmaskTextBoxExt.Text = ipNetwork.Netmask.ToString();
                IPNetworkAddressTextBoxExt.Text = ipNetwork.Network.ToString();
                IPBroadcastAddressTextBoxExt.Text = ipNetwork.Broadcast.ToString();
                IPFirstUsableAddressTextBoxExt.Text = ipNetwork.FirstUsable.ToString();
                IPFirstAddressTextBoxExt.Text = ipNetwork.First.ToString();
                IPLastAddressTextBoxExt.Text = ipNetwork.Last.ToString();
                IPLastUsableAddressTextBoxExt.Text = ipNetwork.LastUsable.ToString();
                IPTotalsTextBoxExt.Text = $"{ipNetwork.Total} / {ipNetwork.Usable}";
            }
            else
            {

            }
        }

        private void ToggleWildcardMask()
        {
            if (IPSubnetsComboBox.SelectedIndex == 0)
            {
                if (wildcardMaskEnabled)
                {
                    IPNetmaskLabel.Text = "Netzmaske:";

                    IPNetmaskTextBoxExt.Text = mainIPNetwork.Netmask.ToString();

                    wildcardMaskEnabled = false;
                }
                else
                {
                    IPNetmaskLabel.Text = "Wildcard-Maske:";

                    IPNetmaskTextBoxExt.Text = mainIPNetwork.WildcardMask.ToString();

                    wildcardMaskEnabled = true;
                }
            }
            else
            {
                if (subnets != null && subnets.Count > 0)
                {
                    if (wildcardMaskEnabled)
                    {
                        IPNetmaskLabel.Text = "Netzmaske:";

                        IPNetmaskTextBoxExt.Text = subnets[IPSubnetsComboBox.SelectedIndex - 1].Netmask.ToString();

                        wildcardMaskEnabled = false;
                    }
                    else
                    {
                        IPNetmaskLabel.Text = "Wildcard-Maske:";

                        IPNetmaskTextBoxExt.Text = subnets[IPSubnetsComboBox.SelectedIndex - 1].WildcardMask.ToString();

                        wildcardMaskEnabled = true;
                    }
                }
            }
        }

        private void ToggleNetmaskBitforms()
        {
            if (IPSubnetsComboBox.SelectedIndex == 0)
            {
                if (bitFormEnabled)
                {
                    if (wildcardMaskEnabled)
                    {
                        IPNetmaskTextBoxExt.Text = mainIPNetwork.WildcardMask.ToString();
                    }
                    else
                    {
                        IPNetmaskTextBoxExt.Text = mainIPNetwork.Netmask.ToString();
                    }

                    bitFormEnabled = false;
                }
                else
                {
                    if (wildcardMaskEnabled)
                    {
                        var bitsForm = mainIPNetwork.WildcardMask.ToString().Split(".").Select(i => Convert.ToString(byte.Parse(i), 2));

                        IPNetmaskTextBoxExt.Text = string.Join(".", bitsForm);
                    }
                    else
                    {
                        var bitsForm = mainIPNetwork.Netmask.ToString().Split(".").Select(i => Convert.ToString(byte.Parse(i), 2));

                        IPNetmaskTextBoxExt.Text = string.Join(".", bitsForm);
                    }

                    bitFormEnabled = true;
                }
            }
            else
            {
                if (subnets != null && subnets.Count > 0)
                {
                    if (bitFormEnabled)
                    {
                        if (wildcardMaskEnabled)
                        {
                            IPNetmaskTextBoxExt.Text = subnets[IPSubnetsComboBox.SelectedIndex - 1].WildcardMask.ToString();
                        }
                        else
                        {
                            IPNetmaskTextBoxExt.Text = subnets[IPSubnetsComboBox.SelectedIndex - 1].Netmask.ToString();
                        }
                        bitFormEnabled = false;
                    }
                    else
                    {
                        if (wildcardMaskEnabled)
                        {
                            var bitsForm = subnets[IPSubnetsComboBox.SelectedIndex - 1].WildcardMask.ToString().Split(".").Select(i => Convert.ToString(byte.Parse(i), 2));
                            IPNetmaskTextBoxExt.Text = string.Join(".", bitsForm);
                        }
                        else
                        {
                            var bitsForm = subnets[IPSubnetsComboBox.SelectedIndex - 1].Netmask.ToString().Split(".").Select(i => Convert.ToString(byte.Parse(i), 2));
                            IPNetmaskTextBoxExt.Text = string.Join(".", bitsForm);
                        }

                        bitFormEnabled = true;
                    }
                }
            }
        }

        private void IPSubnetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IPSubnetsComboBox.SelectedIndex == 0)
            {
                UpdateUI(mainIPNetwork);
            }
            else
            {
                if (subnets != null && subnets.Count > 0)
                {
                    UpdateUI(subnets[IPSubnetsComboBox.SelectedIndex - 1]);
                }
            }
        }

        private void IPInfoControl_Load(object sender, EventArgs e)
        {
            InitializeUI();

            this.ParentForm.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.F8)
                {
                    ToggleWildcardMask();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    ToggleNetmaskBitforms();
                }
            };
        }
    }
}
