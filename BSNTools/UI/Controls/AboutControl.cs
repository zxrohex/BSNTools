using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BSNTools.UI.Controls
{
    public partial class AboutControl : UserControl
    {
        Version version = Assembly.GetExecutingAssembly().GetName().Version;

        public AboutControl()
        {
            InitializeComponent();

            this.AboutVersionLabel.Text = $"Version {version.Major}.{version.Minor}.{version.Build}-prealpha Build {version.Revision}";

            this.DetailedInfoTextBoxExt.Text = $"Version {version.Major}.{version.Minor}.{version.Build}-prealpha Build {version.Revision}\r\n\r\n" +
                $"{RuntimeInformation.FrameworkDescription}\r\n" +
                $"{RuntimeInformation.RuntimeIdentifier}\r\n" +
                "" +
                "";
        }
    }
}
