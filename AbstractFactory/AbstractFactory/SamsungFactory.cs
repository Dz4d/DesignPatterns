using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungFactory : PhoneFactory
    {
        public override Phone GetPhone()
        {
            return new RegularSamsungPhone();
        }

        public override SmartPhone GetSmartPhone()
        {
            return new NokiaSmartPhone();
        }

        
    }
}
