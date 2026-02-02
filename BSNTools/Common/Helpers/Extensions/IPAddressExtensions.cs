using System;
using System.Collections.Generic;
using System.Text;

namespace BSNTools.Common.Helpers.Extensions
{
    public static class IPAddressExtensions
    {
        public static string ToBinaryString(this System.Net.IPAddress ipAddress)
        {
            byte[] bytes = ipAddress.GetAddressBytes();
            StringBuilder binaryString = new StringBuilder();
            foreach (byte b in bytes)
            {
                binaryString.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                binaryString.Append('.');
            }
            // Remove the trailing dot
            if (binaryString.Length > 0)
            {
                binaryString.Length--;
            }
            return binaryString.ToString();
        }
    }
}
