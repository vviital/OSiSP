using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    [ServiceContract]
    public interface ITournamentService
    {
        [OperationContract]
        TournamentType Get(int id);

        [OperationContract]
        IEnumerable<TournamentType> GetAll();

        [OperationContract]
        void Update(TournamentType gameType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(TournamentType country);
    }

    [DataContract]
    public class TournamentType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int GameTypeId { get; set; }

        [DataMember]
        public List<int> ParticipantsId { get; set; }

        [DataMember]
        public int AdminId { get; set; }

        [DataMember]
        public int RestrictionId { get; set; }

        [DataMember]
        public string TournamentName { get; set; }

        [DataMember]
        public DateTime Schedule { get; set; }

        [DataMember]
        public List<int> Rounds { get; set; }

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
