using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IInformation<in T>
        where T : House, new()
    {
        void ShowInformation(T obj);
    }
}
