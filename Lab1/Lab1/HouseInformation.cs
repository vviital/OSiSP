﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HouseInformation : IInformation<House>
    {
        public void ShowInformation(House obj)
        {
            string info = obj.ToString();
            Console.WriteLine(info);
        }
    }
}
