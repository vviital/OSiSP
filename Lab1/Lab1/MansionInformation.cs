namespace Lab1
{
    using System;

    /// <summary>
    /// Class MansionInformation, which can show information about mansion.
    /// </summary>
    public class MansionInformation : IInformation<Mansion>
    {
        /// <summary>
        /// Shows the information about mansion.
        /// </summary>
        /// <param name="obj">The mansion.</param>
        public void ShowInformation(Mansion obj)
        {
            string info = obj.ToString();
            Console.WriteLine(info);
        }
    }
}
