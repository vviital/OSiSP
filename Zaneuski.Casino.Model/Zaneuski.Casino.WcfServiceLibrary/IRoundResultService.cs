namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IRoundResultService
    /// </summary>
    [ServiceContract]
    public interface IRoundResultService 
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        RoundResultType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<RoundResultType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(RoundResultType countryType);

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
        void Add(RoundResultType country);
    }

    /// <summary>
    /// RoundResultType
    /// </summary>
    [DataContract]
    public class RoundResultType
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
        /// Gets or sets the tournament room identifier.
        /// </summary>
        /// <value>
        /// The tournament room identifier.
        /// </value>
        [DataMember]
        public int TournamentRoomId { get; set; }

        /// <summary>
        /// Gets or sets the participant identifier.
        /// </summary>
        /// <value>
        /// The participant identifier.
        /// </value>
        [DataMember]
        public int ParticipantId { get; set; }

        /// <summary>
        /// Gets or sets the gain.
        /// </summary>
        /// <value>
        /// The gain.
        /// </value>
        [DataMember]
        public double Gain { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static RoundResultType ConvertToCompositeType(RoundResult obj)
        {
            RoundResultType type = new RoundResultType()
            {
                Id = obj.Id,
                Gain = obj.Gain,
                ParticipantId = obj.Participant.Id,
                TournamentRoomId = obj.TournamentRoom.Id
            };
            return type;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static RoundResult ConvertFromCompositeType(RoundResultType obj)
        {
            RoundResult round = new RoundResult()
            {
                Id = obj.Id,
                Gain = obj.Gain
            };
            return round;
        }
    }
}
