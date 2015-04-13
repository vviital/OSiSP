using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    class Program
    {
        static void Main(string[] args)
        {
            IBuilder<House> houseBuilder = new HouseBuilder();
            IBuilder<Mansion> mansionBuilder = new MansionBuilder();
            try
            {
                houseBuilder = (IBuilder<House>) mansionBuilder;
                Console.WriteLine("Covariant interface IBuilder<T>");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
