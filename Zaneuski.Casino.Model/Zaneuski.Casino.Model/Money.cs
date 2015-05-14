using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model
{
    class Money
    {
        public double Value { get; set; }

        public Money()
        {
            
        }

        public Money(double value)
        {
            this.Value = value;
        }
    }
}
