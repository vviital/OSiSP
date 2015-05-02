namespace Project_part1
{
    using System;

    /// <summary>
    /// Class which represent game type.
    /// </summary>
    class GameType
    {
        /// <summary>
        /// The type name
        /// </summary>
        private string _typeName;

        /// <summary>
        /// The minimum player rank
        /// </summary>
        private PlayerRank _minimumPlayerRank = new PlayerRank();

        /// <summary>
        /// The maximum player rank
        /// </summary>
        private PlayerRank _maximumPlayerRank = new PlayerRank();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameType"/> class.
        /// </summary>
        public GameType()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameType"/> class.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        public GameType(string typeName)
        {
            this.TypeName = typeName;
            this.MinimumPlayerRank = new PlayerRank(0);
            this.MaximumPlayerRank = new PlayerRank(Int32.MaxValue);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameType"/> class.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <param name="minimumPlayerRank">The minimum player rank.</param>
        /// <param name="maximumPlayerRank">The maximum player rank.</param>
        public GameType(string typeName, PlayerRank minimumPlayerRank, PlayerRank maximumPlayerRank)
        {
            this.TypeName = typeName;
            this.MinimumPlayerRank = minimumPlayerRank;
            this.MaximumPlayerRank = maximumPlayerRank;
        }

        /// <summary>
        /// Gets or sets the name of the type.
        /// </summary>
        /// <value>
        /// The name of the type.
        /// </value>
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        /// <summary>
        /// Gets or sets the minimum player rank.
        /// </summary>
        /// <value>
        /// The minimum player rank.
        /// </value>
        public PlayerRank MinimumPlayerRank
        {
            get { return this._minimumPlayerRank; }
            set { this._minimumPlayerRank = value; }
        }

        /// <summary>
        /// Gets or sets the maximum player rank.
        /// </summary>
        /// <value>
        /// The maximum player rank.
        /// </value>
        public PlayerRank MaximumPlayerRank
        {
            get { return this._maximumPlayerRank; }
            set { this._maximumPlayerRank = value; }
        }
    }
}
