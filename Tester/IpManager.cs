using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class IpManager
    {
        public static string GetIp(string ips)
        {
            var ip = string.Empty;

            var ipArray = ips.Split(',');
            ip = ipArray.GetValue(0).ToString().Trim();
            return ip;
        }

        public static string RemoveIp(string ips)
        {
            var ip = string.Empty;

            var ipArray = ips.Split(',');
            for (var i = 0; i < ips.Count() - 1; i++)
            {
                ip += i;
            }
            return ip;
        }
    }
}
