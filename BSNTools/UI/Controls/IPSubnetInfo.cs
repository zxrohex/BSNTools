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
    public partial class IPSubnetInfo : UserControl
    {
        IPNetwork2 ipNetwork;


        bool firstView = true;

        public IPSubnetInfo(IPNetwork2 ipNetwork)
        {
            InitializeComponent();

            this.ipNetwork = ipNetwork;

            IPAddressTextBox.Text = ipNetwork.ToString();

            CIDRTextBox.Text = ipNetwork.Cidr.ToString();

            SubnetmaskTextBox.Text = ipNetwork.Netmask.ToString();

            NetworkAddressTextBox.Text = ipNetwork.Network.ToString();

            BroadcastAddressTextBox.Text = ipNetwork.Broadcast.ToString();

            UsableAddressesTextBox.Text = ipNetwork.Usable.ToString();

            FirstUsableAddressTextBox.Text = ipNetwork.FirstUsable.ToString();

            LastUsableAddressTextBox.Text = ipNetwork.LastUsable.ToString();

            TotalAddressesTextBox.Text = ipNetwork.Total.ToString();

            FilterComboBox.SelectedIndex = 0;
        }

        private void FilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!firstView)
            {
                AllAddressesListBox.Items.Clear();

                if (FilterComboBox.SelectedIndex == 0)
                {
                    AllAddressesListBox.Items.AddRange(ipNetwork.ListIPAddress(Filter.Usable).Select(ip => ip.ToString()).ToArray());
                }
                else
                {
                    AllAddressesListBox.Items.AddRange(ipNetwork.ListIPAddress(Filter.All).Select(ip => ip.ToString()).ToArray());
                }
            }
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (MainTabControl.SelectedIndex == 1)
            {
                if (firstView)
                {
                    AllAddressesListBox.Items.AddRange(ipNetwork.ListIPAddress(Filter.Usable).Select(ip => ip.ToString()).ToArray());

                    firstView = false;
                }
            }
            
        }
    }
}
