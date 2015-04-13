using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("-------\n");
            builder.Append(typeof(Mansion) + "\n");
            builder.Append(base.ToString());
            builder.Append("Number of floors: " + this.NumberOfFloors.ToString() + "\n");
            builder.Append("-------\n");
            return builder.ToString();
        }
    }
}
