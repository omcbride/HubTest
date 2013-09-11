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

        public static string RemoveIp(string ips, int location)
        {
            var ipList = string.Empty;

            var ipArray = ips.Split(',');
            var count = ipArray.Count();
            for (var i = 0; i < count; i++)
            {
                if (i == location) continue;
                ipList += ipArray[i];
                if (i < count - 1)
                    ipList += ",";
            }
            return ipList;
        }
    }
}
