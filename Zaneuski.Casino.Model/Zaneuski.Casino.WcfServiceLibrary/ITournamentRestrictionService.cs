namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// ITournamentRestrictionService
    /// </summary>
    [ServiceContract]
    public interface ITournamentRestrictionService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        TournamentRestrictionType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<TournamentRestrictionType> GetAll();

        /// <summary>
        /// Updates the specified tournament restriction.
        /// </summary>
        /// <param name="tournamentRestriction">The tournament restriction.</param>
        [OperationContract]
        void Update(TournamentRestrictionType tournamentRestriction);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [OperationContract]
        void Delete(int id);

        /// <summary>
        /// Adds the specified tournament restriction type.
        /// </summary>
        /// <param name="tournamentRestrictionType">Type of the tournament restriction.</param>
        [OperationContract]
        void Add(TournamentRestrictionType tournamentRestrictionType);
    }

    /// <summary>
    /// TournamentRestrictionType
    /// </summary>
    [DataContract]
    public class TournamentRestrictionType
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of wins.
        /// </summary>
        /// <value>
        /// The minimum number of wins.
        /// </value>
        [DataMember]
        public int MinimumNumberOfWins { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of wins.
        /// </summary>
        /// <value>
        /// The maximum number of wins.
        /// </value>
        [DataMember]
        public int MaximumNumberOfWins { get; set; }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        [DataMember]
        public double Fee { get; set; }

        /// <summary>
        /// Gets or sets the tournaments.
        /// </summary>
        /// <value>
        /// The tournaments.
        /// </value>
        [DataMember]
        public List<int> Tournaments { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="restriction">The restriction.</param>
        /// <returns></returns>
        public static TournamentRestrictionType ConvertToCompositeType(TournamentRestriction restriction)
        {
            TournamentRestrictionType tournamentRestriction = new TournamentRestrictionType()
            {
                Id = restriction.Id,
                Fee = restriction.Fee,
                MinimumNumberOfWins = restriction.MinimumNumberOfWins,
                MaximumNumberOfWins = restriction.MaximumNumberOfWins
            };
            tournamentRestriction.Tournaments = new List<int>();
            foreach (var item in restriction.Tournaments)
            {
                tournamentRestriction.Tournaments.Add(item.Id);
            }
            return tournamentRestriction;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static TournamentRestriction ConvertFromCompositeType(TournamentRestrictionType type)
        {
            TournamentRestriction restriction = new TournamentRestriction()
            {
                Id = type.Id,
                Fee = type.Fee,
                MaximumNumberOfWins = type.MaximumNumberOfWins,
                MinimumNumberOfWins = type.MinimumNumberOfWins
            };
            return restriction;
        }
    }
}
