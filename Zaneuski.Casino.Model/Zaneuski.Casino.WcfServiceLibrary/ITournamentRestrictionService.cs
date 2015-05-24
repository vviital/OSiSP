using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    [ServiceContract]
    public interface ITournamentRestrictionService
    {
        [OperationContract]
        TournamentRestrictionType Get(int id);

        [OperationContract]
        IEnumerable<TournamentRestrictionType> GetAll();

        [OperationContract]
        void Update(TournamentRestrictionType tournamentRestriction);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(TournamentRestrictionType tournamentRestrictionType);
    }

    [DataContract]
    public class TournamentRestrictionType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int MinimumNumberOfWins { get; set; }

        [DataMember]
        public int MaximumNumberOfWins { get; set; }

        [DataMember]
        public double Fee { get; set; }

        [DataMember]
        public List<int> Tournaments { get; set; }

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
