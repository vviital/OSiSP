namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IRoundService
    /// </summary>
    [ServiceContract]
    public interface IRoundService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        RoundType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<RoundType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(RoundType countryType);

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
        void Add(RoundType country);
    }

    /// <summary>
    /// RoundType
    /// </summary>
    [DataContract]
    public class RoundType
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
        /// Gets or sets the room number.
        /// </summary>
        /// <value>
        /// The room number.
        /// </value>
        [DataMember]
        public int RoomNumber { get; set; }

        /// <summary>
        /// Gets or sets the round results identifier.
        /// </summary>
        /// <value>
        /// The round results identifier.
        /// </value>
        [DataMember]
        public virtual List<int> RoundResultsId { get; set; }

        /// <summary>
        /// Gets or sets the tournament.
        /// </summary>
        /// <value>
        /// The tournament.
        /// </value>
        [DataMember]
        public virtual int Tournament { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static RoundType ConvertToCompositeType(Round obj)
        {
            RoundType type = new RoundType()
            {
                Id = obj.Id,
                RoomNumber = obj.RoomNumber,
                RoundResultsId = new List<int>(),
                Tournament = obj.Tournament.Id
            };
            foreach (var item in obj.RoundResults)
            {
                type.RoundResultsId.Add(item.Id);
            }
            return type;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static Round ConvertFromCompositeType(RoundType obj)
        {
            Round round = new Round()
            {
                Id = obj.Id,
                RoomNumber = obj.RoomNumber
            };
            return round;
        }
    }
}
