namespace Lab1
{
    /// <summary>
    /// The Information interface.
    /// </summary>
    /// <typeparam name="T">
    /// must have a base class House
    /// </typeparam>
    public interface IInformation<in T>
        where T : House, new()
    {
        /// <summary>
        /// Shows the information about house.
        /// </summary>
        /// <param name="obj">The object.</param>
        void ShowInformation(T obj);
    }
}
