using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HouseBuilder : IBuilder<House>
    {
        public House Build()
        {
            return new House();
        }
    }
}
