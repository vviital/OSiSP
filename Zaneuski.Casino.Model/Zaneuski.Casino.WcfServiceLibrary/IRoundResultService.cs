using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    [ServiceContract]
    public interface IRoundResultService 
    {
        [OperationContract]
        RoundResultType Get(int id);

        [OperationContract]
        IEnumerable<RoundResultType> GetAll();

        [OperationContract]
        void Update(RoundResultType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(RoundResultType country);
    }

    [DataContract]
    public class RoundResultType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int TournamentRoomId { get; set; }

        [DataMember]
        public int ParticipantId { get; set; }

        [DataMember]
        public double Gain { get; set; }

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
