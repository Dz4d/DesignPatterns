using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new PoorFactory();
            IPaymenthMethod paymenthmethod1 = factory.GetBlik();
            IPaymenthMethod paymenthmethod2 = factory.GetVisa();
            IPaymenthMethod paymenthmethod3 = factory.GetMastercard();
            

            Console.WriteLine(paymenthmethod1.Pay(20.0M));
            Console.WriteLine(paymenthmethod2.Pay(20.0M));
            Console.WriteLine(paymenthmethod3.Pay(20.0M));
            Console.ReadKey();
        }
    }
}
