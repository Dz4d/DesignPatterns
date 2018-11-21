using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        Phone p;
        SmartPhone sp;
        public Client(PhoneFactory factory)
        {
            p = factory.GetPhone();
            sp = factory.GetSmartPhone();
        }

        public string GetPhones()
        {
            return $"{p.ToString()} and {sp.ToString()}";
        }
    }
}
