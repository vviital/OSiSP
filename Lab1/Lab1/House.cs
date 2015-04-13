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
    }
}
