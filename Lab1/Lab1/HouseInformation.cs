namespace Lab1
{
    using System;

    /// <summary>
    /// Class HouseInformation, which can show information about house.
    /// </summary>
    public class HouseInformation : IInformation<House>
    {
        /// <summary>
        /// Shows the information.
        /// </summary>
        /// <param name="obj">The House.</param>
        public void ShowInformation(House obj)
        {
            string info = obj.ToString();
            Console.WriteLine(info);
        }
    }
}
