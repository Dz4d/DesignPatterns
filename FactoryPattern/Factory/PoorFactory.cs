using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnFactory
{
    class PoorFactory : Factory
    {
        public override IPaymenthMethod GetBlik() => new Blik();

        public override IPaymenthMethod GetMastercard() => new Mastercard(1000.0M);

        public override IPaymenthMethod GetVisa() => new Visia(10.0M);
    }
}
