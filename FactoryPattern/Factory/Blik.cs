using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnFactory
{
    class Blik:IPaymenthMethod
    {
        public Blik(decimal StartAmount = 100)
        {
            Cash = StartAmount;
        }

        public decimal Cash { get; set; }

        public string Pay(decimal amount)
        {
            Cash = Cash - amount;
            return $"Blik Pay, left amount {Cash}";
        }
    }
}
