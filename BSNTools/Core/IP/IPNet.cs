using System;
using System.Collections.Generic;
using System.Text;

namespace BSNTools.Core.IP
{
    public class IPNet
    {
        public static string GetIPAddressType(string ipAddress)
        {
            if (System.Net.IPAddress.TryParse(ipAddress, out var address))
            {
                return address.AddressFamily.ToString();
            }
            else
            {
                throw new ArgumentException("Invalid IP address format.");
            }
        }

        public static string GetIPWithoutCIDR(string ipAddress)
        {
            if (ipAddress.Contains("/"))
            {
                return ipAddress.Split('/')[0];
            }
            else
            {
                return ipAddress;
            }
        }
    }
}
