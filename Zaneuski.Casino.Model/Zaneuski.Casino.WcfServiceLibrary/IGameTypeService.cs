namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IGameTypeService
    /// </summary>
    [ServiceContract]
    public interface IGameTypeService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        GameTypesType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<GameTypesType> GetAll();

        /// <summary>
        /// Updates the specified game type.
        /// </summary>
        /// <param name="gameType">Type of the game.</param>
        [OperationContract]
        void Update(GameTypesType gameType);

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
        void Add(GameTypesType country);
    }

    /// <summary>
    /// GameTypesType
    /// </summary>
    [DataContract]
    public class GameTypesType
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
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the tournaments identifier.
        /// </summary>
        /// <value>
        /// The tournaments identifier.
        /// </value>
        [DataMember]
        public List<int> TournamentsId { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static GameTypesType ConvertToCompositeType(GameType source)
        {
            GameTypesType gameType = new GameTypesType() { Id = source.Id, Type = source.Type };
            gameType.TournamentsId = new List<int>();
            foreach (var item in source.Tournaments)
            {
                gameType.TournamentsId.Add(item.Id);
            }
            return gameType;
        }

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static GameType ConvertFromCompositeType(GameTypesType source)
        {
            GameType gameType = new GameType() { Id = source.Id, Type = source.Type };
            return gameType;
        }
    }
}
