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
    }
}
