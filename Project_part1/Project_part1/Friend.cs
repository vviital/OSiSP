namespace Project_part1
{
    using System;

    /// <summary>
    /// Class which represent friend.
    /// </summary>
    class Friend
    {
        /// <summary>
        /// The player
        /// </summary>
        private Player _player;

        /// <summary>
        /// The date added
        /// </summary>
        private DateTime _dateAdded;

        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        public Friend()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="dateAdded">The date added.</param>
        public Friend(Player player, DateTime dateAdded)
        {
            this.PlayerFriend = player;
            this.DataAdded = dateAdded;
        }

        /// <summary>
        /// Gets or sets the player friend.
        /// </summary>
        /// <value>
        /// The player friend.
        /// </value>
        public Player PlayerFriend 
        {
            get { return this._player; }
            set { this._player = value; }
        }

        /// <summary>
        /// Gets or sets the data added.
        /// </summary>
        /// <value>
        /// The data added.
        /// </value>
        public DateTime DataAdded
        {
            get { return this._dateAdded; }
            set { this._dateAdded = value; }
        }
    }
}
