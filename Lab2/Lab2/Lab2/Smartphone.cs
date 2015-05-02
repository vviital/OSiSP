namespace Lab2
{
    /// <summary>
    /// Class which represent Smartphone.
    /// </summary>
    [Alias(AlternativeName = "SPhone")]
    public class Smartphone : Computer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Smartphone"/> class.
        /// </summary>
        public Smartphone()
            : base()
        {
            this.DisplayLength = Prng.Next(100, 2000);
            this.DisplayWidth = Prng.Next(100, 2000);
            this.PhotoCount = 0;
        }

        /// <summary>
        /// Gets or sets the display length.
        /// </summary>
        /// <value>
        /// The display length.
        /// </value>
        public int DisplayLength { get; set; }

        /// <summary>
        /// Gets or sets the display width.
        /// </summary>
        /// <value>
        /// The display width.
        /// </value>
        public int DisplayWidth { get; set; }

        /// <summary>
        /// Gets or sets the photo count.
        /// </summary>
        /// <value>
        /// The photo count.
        /// </value>
        public int PhotoCount { get; set; }

        /// <summary>
        /// Makes the photo.
        /// </summary>
        public void MakePhoto()
        {
            this.PhotoCount++;
        }
    }
}
