using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
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


        public IPInfoControl()
        {
            InitializeComponent();
        }

        private void UpdateUI(IPNetwork2 ipNetwork)
        {
            if (ipNetwork != null)
            {
                IPSubnetsComboBox.Items.Clear();

                IPSubnetsComboBox.Items.Add(ipNetwork.ToString());
                IPAddressCIDRTextBoxExt.Text = ipNetwork.ToString();
                IPNetmaskTextBoxExt.Text = ipNetwork.Netmask.ToString();
                IPNetworkAddressTextBoxExt.Text = ipNetwork.Network.ToString();
                IPBroadcastAddressTextBoxExt.Text = ipNetwork.Broadcast.ToString();
                IPFirstUsableAddressTextBoxExt.Text = ipNetwork.FirstUsable.ToString();
                IPFirstAddressTextBoxExt.Text = ipNetwork.First.ToString();
                IPLastAddressTextBoxExt.Text = ipNetwork.Last.ToString();
                IPLastUsableAddressTextBoxExt.Text = ipNetwork.LastUsable.ToString();
                IPTotalsTextBoxExt.Text = $"{ipNetwork.Total} / {ipNetwork.Usable}";

                if (subnets != null)
                {
                    foreach (var subnet in subnets)
                    {
                        IPSubnetsComboBox.Items.Add(subnet.ToString());
                    }

                    IPSubnetsComboBox.Enabled = true;
                }
                else
                {
                    IPSubnetsComboBox.Enabled = false;
                }

                IPSubnetsComboBox.SelectedIndex = 0;
            }
            else
            {

            }


        }

        private void IPSubnetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IPSubnetsComboBox.SelectedIndex == 0)
            {
                
            }
        }
    }
}
