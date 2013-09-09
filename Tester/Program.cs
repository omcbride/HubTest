using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var ips = "1.2.3.4, 5.6.7.8";
            Console.Write(GetIp(ips));
            Console.ReadLine();
        }

         private static string GetIp(string ips)
        {
            var ip = string.Empty;
            
                   var ipArray = ips.Split(',');
                   ip = ipArray.GetValue(0).ToString().Trim();
            return ip;
        }
    }
}
