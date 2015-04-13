namespace Lab1
{
    /// <summary>
    /// The Builder interface.
    /// </summary>
    /// <typeparam name="T">
    /// must have a base class House
    /// </typeparam>
    public interface IBuilder<out T>
        where T : House, new()
    {
        /// <summary>
        /// Builds house.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>
        /// </returns>
        T Build();
    }
}
