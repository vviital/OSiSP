namespace Lab1
{
    /// <summary>
    /// Class HouseBuilder which can build house.
    /// </summary>
    public class HouseBuilder : IBuilder<House>
    {
        /// <summary>
        /// Builds house.
        /// </summary>
        /// <returns>
        /// The <see cref="House"/>
        /// </returns>
        public House Build()
        {
            return new House();
        }
    }
}
