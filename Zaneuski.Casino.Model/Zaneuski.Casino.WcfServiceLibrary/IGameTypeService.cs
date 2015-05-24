using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    [ServiceContract]
    public interface IGameTypeService
    {
        [OperationContract]
        GameTypesType Get(int id);

        [OperationContract]
        IEnumerable<GameTypesType> GetAll();

        [OperationContract]
        void Update(GameTypesType gameType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(GameTypesType country);
    }
    
    [DataContract]
    public class GameTypesType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public List<int> TournamentsId { get; set; }
        
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

        public static GameType ConvertFromCompositeType(GameTypesType source)
        {
            GameType gameType = new GameType() { Id = source.Id, Type = source.Type };
            return gameType;
        }
    }
}
