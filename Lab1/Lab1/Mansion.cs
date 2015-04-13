using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Mansion : House
    {
        public Mansion()
            : base()
        {
            Random rand = new Random();
            this.NumberOfFloors = rand.Next() % 10 + 1;
        }
        public int NumberOfFloors { get; set; }
    }
}
