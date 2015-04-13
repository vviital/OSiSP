using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MansionBuilder : IBuilder<Mansion>
    {
        public Mansion Build()
        {
            return new Mansion();
        }
    }
}
