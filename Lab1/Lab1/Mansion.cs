namespace Lab1
{
    using System;
    using System.Text;

    /// <summary>
    /// Class Mantion, which represent some mansion.
    /// </summary>
    public class Mansion : House
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mansion"/> class.
        /// </summary>
        public Mansion()
            : base()
        {
            Random rand = new Random();
            this.NumberOfFloors = (rand.Next() % 10) + 1;
        }

        /// <summary>
        /// Gets or sets the number of floors.
        /// </summary>
        /// <value>
        /// The number of floors.
        /// </value>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("-------\n");
            builder.Append(typeof(Mansion) + "\n");
            builder.Append(base.ToString());
            builder.Append("Number of floors: " + this.NumberOfFloors.ToString() + "\n");
            builder.Append("-------\n");
            return builder.ToString();
        }
    }
}
