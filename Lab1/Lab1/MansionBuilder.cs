namespace Lab1
{
    /// <summary>
    /// Class MansionBuilder, which can build mansion.
    /// </summary>
    public class MansionBuilder : IBuilder<Mansion>
    {
        /// <summary>
        /// Builds mansion.
        /// </summary>
        /// <returns>
        /// The <see cref="Mansion" />
        /// </returns>
        public Mansion Build()
        {
            return new Mansion();
        }
    }
}
