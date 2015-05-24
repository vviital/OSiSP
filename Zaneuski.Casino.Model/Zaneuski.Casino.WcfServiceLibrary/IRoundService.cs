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
    public interface IRoundService
    {
        [OperationContract]
        RoundType Get(int id);

        [OperationContract]
        IEnumerable<RoundType> GetAll();

        [OperationContract]
        void Update(RoundType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(RoundType country);
    }

    [DataContract]
    public class RoundType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int RoomNumber { get; set; }

        [DataMember]
        public virtual List<int> RoundResultsId { get; set; }

        [DataMember]
        public virtual int Tournament { get; set; }

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
