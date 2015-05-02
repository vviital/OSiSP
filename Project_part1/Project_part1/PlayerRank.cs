namespace Project_part1
{
    using System;

    /// <summary>
    /// Class which represent player rank.
    /// </summary>
    class PlayerRank : IComparable
    {
        /// <summary>
        /// The rating
        /// </summary>
        private int _rating;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRank"/> class.
        /// </summary>
        public PlayerRank()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRank"/> class.
        /// </summary>
        /// <param name="rating">The rating.</param>
        public PlayerRank(int rating)
        {
            this.Rating = rating;
        }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public int Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.
        /// </returns>
        public int CompareTo(Object obj)
        {
            if (!(obj is PlayerRank)) return 0;
            return this.Rating.CompareTo((obj as PlayerRank).Rating);
        }
    }
}
