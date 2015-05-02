namespace Project_part1
{
    using System.Collections.Generic;

    /// <summary>
    /// Class which represent round result
    /// </summary>
    class RoundResult
    {
        /// <summary>
        /// The round results
        /// </summary>
        private List<RoundResult> roundResults = new List<RoundResult>();

        /// <summary>
        /// The room identifier
        /// </summary>
        private int _roomID;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResult"/> class.
        /// </summary>
        public RoundResult()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResult"/> class.
        /// </summary>
        /// <param name="roomID">The room identifier.</param>
        public RoundResult(int roomID)
        {
            this.RoomID = roomID;
        }

        /// <summary>
        /// Gets or sets the round results.
        /// </summary>
        /// <value>
        /// The round results.
        /// </value>
        public List<RoundResult> RoundResults
        {
            get { return this.roundResults; }
            set { this.roundResults = value; }
        }

        /// <summary>
        /// Gets or sets the room identifier.
        /// </summary>
        /// <value>
        /// The room identifier.
        /// </value>
        public int RoomID
        {
            get { return this._roomID; }
            set { this._roomID = value; }
        }
    }
}
