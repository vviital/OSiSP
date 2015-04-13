using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MansionInformation : IInformation<Mansion>
    {
        public void ShowInformation(Mansion obj)
        {
            string info = obj.ToString();
            Console.WriteLine(info);
        }
    }
}
