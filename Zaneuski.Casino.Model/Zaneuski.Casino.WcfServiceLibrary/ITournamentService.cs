namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// ITournamentService
    /// </summary>
    [ServiceContract]
    public interface ITournamentService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        TournamentType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<TournamentType> GetAll();

        /// <summary>
        /// Updates the specified game type.
        /// </summary>
        /// <param name="gameType">Type of the game.</param>
        [OperationContract]
        void Update(TournamentType gameType);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [OperationContract]
        void Delete(int id);

        /// <summary>
        /// Adds the specified country.
        /// </summary>
        /// <param name="country">The country.</param>
        [OperationContract]
        void Add(TournamentType country);
    }

    /// <summary>
    /// TournamentType
    /// </summary>
    [DataContract]
    public class TournamentType
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
        /// Gets or sets the game type identifier.
        /// </summary>
        /// <value>
        /// The game type identifier.
        /// </value>
        [DataMember]
        public int GameTypeId { get; set; }

        /// <summary>
        /// Gets or sets the participants identifier.
        /// </summary>
        /// <value>
        /// The participants identifier.
        /// </value>
        [DataMember]
        public List<int> ParticipantsId { get; set; }

        /// <summary>
        /// Gets or sets the admin identifier.
        /// </summary>
        /// <value>
        /// The admin identifier.
        /// </value>
        [DataMember]
        public int AdminId { get; set; }

        /// <summary>
        /// Gets or sets the restriction identifier.
        /// </summary>
        /// <value>
        /// The restriction identifier.
        /// </value>
        [DataMember]
        public int RestrictionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the tournament.
        /// </summary>
        /// <value>
        /// The name of the tournament.
        /// </value>
        [DataMember]
        public string TournamentName { get; set; }

        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        /// <value>
        /// The schedule.
        /// </value>
        [DataMember]
        public DateTime Schedule { get; set; }

        /// <summary>
        /// Gets or sets the rounds.
        /// </summary>
        /// <value>
        /// The rounds.
        /// </value>
        [DataMember]
        public List<int> Rounds { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static TournamentType ConvertToCompositeType(Tournament source)
        {
            TournamentType tournament = new TournamentType()
            {
                Id = source.Id,
                AdminId = source.Admin != null ? source.Admin.Id : -1,
                GameTypeId = source.GameType != null ? source.GameType.Id : -1,
                RestrictionId = source.Restriction != null ? source.Restriction.Id : -1,
                Schedule = source.Schedule,
                TournamentName = source.TournamentName,
                ParticipantsId = new List<int>(),
                Rounds = new List<int>()
            };
            foreach (var participant in source.Participants)
            {
                tournament.ParticipantsId.Add(participant.Id);
            }
            foreach (var round in source.Rounds)
            {
                tournament.Rounds.Add(round.Id);
            }
            return tournament;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static Tournament ConvertFromCompositeType(TournamentType source)
        {
            Tournament tournament = new Tournament()
            {
                Id = source.Id,
                TournamentName = source.TournamentName,
                Schedule = source.Schedule
            };
            return tournament;
        }
    }
}
