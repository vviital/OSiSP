using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class House
    {
        public House()
        {
            Random rand = new Random();
            this.BuildingArea = rand.Next() % 1000 + 10;
            this.NumberOfRooms = rand.Next() % 20 + 1;
        }

        public int BuildingArea { get; set; }

        public int NumberOfRooms { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(typeof (House));
            builder.Append("Building area: " + this.BuildingArea.ToString() + "\n");
            builder.Append("Number of rooms: " + this.NumberOfRooms.ToString() + "\n");
            return builder.ToString();
        }
    }
}
