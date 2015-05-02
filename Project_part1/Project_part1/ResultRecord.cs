namespace Project_part1
{
    using System;

    /// <summary>
    /// Class which represent result record.
    /// </summary>
    class ResultRecord : IComparable
    {
        /// <summary>
        /// The player
        /// </summary>
        private Player _player = new Player();

        /// <summary>
        /// The gain
        /// </summary>
        private double _gain;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultRecord"/> class.
        /// </summary>
        public ResultRecord()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultRecord"/> class.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="gain">The gain.</param>
        public ResultRecord(Player player, double gain)
        {
            this.PlayerLogin = player;
            this.Gain = gain;
        }

        /// <summary>
        /// Gets or sets the player login.
        /// </summary>
        /// <value>
        /// The player login.
        /// </value>
        public Player PlayerLogin 
        {
            get { return this._player; }
            set { this._player = value; }
        }

        /// <summary>
        /// Gets or sets the gain.
        /// </summary>
        /// <value>
        /// The gain.
        /// </value>
        public double Gain
        {
            get { return this._gain; }
            set { this._gain = value; }
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
            if (!(obj is ResultRecord)) return 0;
            return this.Gain.CompareTo((obj as ResultRecord).Gain);
        }
    }
}
