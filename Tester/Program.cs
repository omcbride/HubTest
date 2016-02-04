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
            var ip = IpManager.GetIp("1.2.3.4, 5.6.7.8, 9.0.9.8");
            Console.Write(ip);
            Console.ReadLine();
        }
    }
}
