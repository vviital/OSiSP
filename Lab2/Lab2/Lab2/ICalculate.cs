namespace Lab2
{
    /// <summary>
    /// Interface ICalculate with one method.
    /// </summary>
    [Alias(AlternativeName = "ICalc")]
    public interface ICalculate
    {
        /// <summary>
        /// Calculates this instance.
        /// </summary>
        /// <returns>
        /// Integer value
        /// </returns>
        int Calculate();
    }
}
