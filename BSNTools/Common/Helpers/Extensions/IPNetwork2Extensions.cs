using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BSNTools.Common.Helpers.Extensions
{
    public static class IPNetwork2Extensions
    {
        public static string ToStringWithoutCidr(this IPNetwork2 ipNetwork)
        {
            return ipNetwork.ToString().Split('/')[0];
        }

        public static string ToBinaryString(this IPNetwork2 ipNetwork)
        {
            return string.Join(".", ipNetwork.ToStringWithoutCidr().Split(".").Select(i => Convert.ToString(byte.Parse(i), 2).PadLeft(8, '0')));
        }

    }
}
