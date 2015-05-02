namespace Lab2
{
    /// <summary>
    /// Class which represent Laptop.
    /// </summary>
    [Alias(AlternativeName = "LTop")]
    public class Laptop : Computer, ICalculate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Laptop"/> class by using pseudorandom number generator.
        /// </summary>
        public Laptop()
            : base()
        {
            this.Weight = this.Prng.Next(100, 1000);
            this.Length = this.Prng.Next(100, 1000);
            this.Width = this.Prng.Next(100, 1000);
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length { get; set; }

        /// <summary>
        /// Calculates this instance.
        /// </summary>
        /// <returns>
        /// Integer value
        /// </returns>
        public int Calculate()
        {
            return this.Prng.Next();
        }
    }
}
