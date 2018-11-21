using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client(new SamsungFactory());
            Client c2 = new Client(new NokiaFactory());
            Console.WriteLine(c.GetPhones());
            Console.WriteLine(c2.GetPhones());
            Console.ReadKey();
        }
    }
}
