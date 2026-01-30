using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BSNTools.Core.IP
{
    public class IPTools
    {
        public static int GetAddressesTotalCount(string ipAddressNotation)
        {
            return (int)IPNetwork2.Parse(ipAddressNotation, true).Total;
        }

        public static int GetSubnetCount(string ipAddressNotation, byte cidr)
        {
            return (int)IPNetwork2.Parse(ipAddressNotation, true).Subnet(cidr).Count;
        }

        public static int GetAddressesCountPerSubnet(string ipAddressNotation, byte cidr)
        {
            return (int)IPNetwork2.Parse(ipAddressNotation, true).Subnet(cidr)[0].Total;
        }


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
