using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnFactory
{
    abstract class Factory
    {
        public abstract IPaymenthMethod GetBlik();
        public abstract IPaymenthMethod GetVisa();

        public abstract IPaymenthMethod GetMastercard();
    }
}
