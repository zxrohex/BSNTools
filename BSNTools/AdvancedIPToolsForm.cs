using BSNTools.Common.Helpers.Extensions;
using BSNTools.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BSNTools
{
    public partial class AdvancedIPToolsForm : Form
    {
        IPNetwork2 mainIPNetwork;

        IPNetworkCollection subnets;

        byte subnetCidr;

        IPInfoControl refIPInfoControl;

        public AdvancedIPToolsForm(IPInfoControl refIPInfoControl)
        {
            InitializeComponent();

            this.refIPInfoControl = refIPInfoControl;

            this.mainIPNetwork = refIPInfoControl.MainIPNetwork;

            this.subnets = refIPInfoControl.Subnets;

            this.subnetCidr = refIPInfoControl.SourceCidr;

            UpdateIPBitsVisualization();
        }

        private void UpdateIPBitsVisualization()
        {
            
            if (subnetCidr > 0 && subnets != null && subnets.Count > 0)
            {
                IPNetwork2 firstSubnet = subnets[0];

                int additionalNetbits = subnetCidr - mainIPNetwork.Cidr;


                string netbits = firstSubnet.Netmask.ToBinaryString().Substring(0, firstSubnet.Netmask.ToBinaryString().IndexOf('0') - additionalNetbits);

                string subnetBits = firstSubnet.Netmask.ToBinaryString().Substring(firstSubnet.Netmask.ToBinaryString().IndexOf('0') - additionalNetbits, additionalNetbits);

                string hostbits = firstSubnet.Netmask.ToBinaryString().Substring(firstSubnet.Netmask.ToBinaryString().IndexOf('0'));


                NetbitsLabel.Text = netbits;

                HostbitsLabel.Text = hostbits;

                NetbitsHeaderLabel.Text = $"{netbits.Replace(".", "").Length} Netzbits";

                HostbitsHeaderLabel.Text = $"{hostbits.Replace(".", "").Length} Hostbits";

                SubnetbitsLabel.Text = $"{subnetBits}";

                SubnetbitsHeaderLabel.Text = $"{subnetBits.Replace(".", "").Length} Subnetbits";

                IPAddressBitVisualizationTableLayoutPanel.ColumnStyles[1].Width = 33.33F;
            } 
            else
            {
                string netbits = mainIPNetwork.Netmask.ToBinaryString().Substring(0, mainIPNetwork.Netmask.ToBinaryString().IndexOf('0'));

                string hostbits = mainIPNetwork.Netmask.ToBinaryString().Substring(mainIPNetwork.Netmask.ToBinaryString().IndexOf('0'));

                NetbitsLabel.Text = netbits;

                HostbitsLabel.Text = hostbits;

                

                NetbitsHeaderLabel.Text = $"{netbits.Replace(".", "").Length} Netzbits";

                HostbitsHeaderLabel.Text = $"{hostbits.Replace(".", "").Length} Hostbits";

                IPAddressBitVisualizationTableLayoutPanel.ColumnStyles[1].Width = 0;
            }

           
        }
    }
}
