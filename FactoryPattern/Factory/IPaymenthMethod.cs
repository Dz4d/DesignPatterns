using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnFactory
{
    interface IPaymenthMethod
    {
        decimal Cash { get; set; }
        string Pay(decimal amount);
    }
}
