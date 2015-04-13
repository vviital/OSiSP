namespace Lab1
{
    using System;
    using System.Text;

    /// <summary>
    /// Class House which represent some house.
    /// </summary>
    public class House
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="House"/> class.
        /// </summary>
        public House()
        {
            Random rand = new Random();
            this.BuildingArea = (rand.Next() % 1000) + 10;
            this.NumberOfRooms = (rand.Next() % 20) + 1;
        }

        /// <summary>
        /// Gets or sets the building area.
        /// </summary>
        /// <value>
        /// The building area.
        /// </value>
        public int BuildingArea { get; set; }

        /// <summary>
        /// Gets or sets the number of rooms.
        /// </summary>
        /// <value>
        /// The number of rooms.
        /// </value>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(typeof(House));
            builder.Append("Building area: " + this.BuildingArea.ToString() + "\n");
            builder.Append("Number of rooms: " + this.NumberOfRooms.ToString() + "\n");
            return builder.ToString();
        }
    }
}
