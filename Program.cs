using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyFristWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用ServiceHost 启动服务
            ServiceHost service = new ServiceHost(typeof(TeachService));
            service.Open();
            Console.WriteLine("C#WCF服务启动。。。");
            Console.Read();
        }
    }
}
