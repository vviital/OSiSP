namespace Lab1
{
    using System;

    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            IBuilder<House> houseBuilder = new HouseBuilder();
            IBuilder<Mansion> mansionBuilder = new MansionBuilder();
            try
            {
                houseBuilder = (IBuilder<House>)mansionBuilder;
                Console.WriteLine("Covariant interface IBuilder<T>");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Interface IBuilder<T> isn't covariant");
            }

            houseBuilder = new HouseBuilder();
            mansionBuilder = new MansionBuilder();
            try
            {
                mansionBuilder = (IBuilder<Mansion>)houseBuilder;
                Console.WriteLine("Contravariant interface IBuilder<T>");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Interface IBuilder<T> isn't contravariant");
            }

            IInformation<House> houseInformation = new HouseInformation();
            IInformation<Mansion> mansionInformation = new MansionInformation();

            try
            {
                houseInformation = (IInformation<House>)mansionInformation;
                Console.WriteLine("Covariant interface IInformation<T>");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Interface IInformation<T> isn't covariant");
            }

            houseInformation = new HouseInformation();
            mansionInformation = new MansionInformation();

            try
            {
                mansionInformation = (IInformation<Mansion>)houseInformation;
                Console.WriteLine("Contravariant interface IInformation<T>");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Interface IInformation<T> isn't contravariant");
            }
        }
    }
}
