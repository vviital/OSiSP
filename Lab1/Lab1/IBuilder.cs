using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IBuilder<out T>
        where T : House, new()
    {
        T Build();
    }
}
