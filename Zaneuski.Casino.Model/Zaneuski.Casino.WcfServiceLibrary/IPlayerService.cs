using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    [ServiceContract]
    public interface IPlayerService
    {
        [OperationContract]
        PlayerType Get(int id);

        [OperationContract]
        IEnumerable<PlayerType> GetAll();

        [OperationContract]
        void Update(PlayerType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(PlayerType country);
    }

    [DataContract]
    public class PlayerType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public bool Sex { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public DateTime Birth { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public double AccountBalance { get; set; }

        [DataMember]
        public bool VerifyFlag { get; set; }

        [DataMember]
        public List<int> IsFriends { get; set; }

        [DataMember]
        public List<int> HaveFriends { get; set; }

        [DataMember]
        public int Admin { get; set; }

        [DataMember]
        public List<int> Tournaments { get; set; }

        [DataMember]
        public int Passport { get; set; }

        [DataMember]
        public List<int> RoundResults { get; set; }

        [DataMember]
        public int Country { get; set; }

        public static PlayerType ConvertToCompositeType(Player obj)
        {
            PlayerType playerType = new PlayerType()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                AccountBalance = obj.AccountBalance,
                Country = obj.Country.Id,
                Email = obj.Email,
                Admin = obj.Admin.Id,
                FirstName = obj.FirstName,
                Login = obj.Login,
                Passport = obj.Passport.Id,
                Sex = obj.Sex,
                Password = obj.Password,
                PhoneNumber = obj.PhoneNumber,
                Surname = obj.Surname,
                VerifyFlag = obj.VerifyFlag,
                HaveFriends = new List<int>(),
                IsFriends = new List<int>(),
                Tournaments = new List<int>(),
                RoundResults = new List<int>()
            };
            foreach (var friend in obj.haveFriends)
            {
                playerType.HaveFriends.Add(friend.Id);
            }
            foreach (var friend in obj.isFriends)
            {
                playerType.IsFriends.Add(friend.Id);
            }
            foreach (var tournament in obj.Tournaments)
            {
                playerType.Tournaments.Add(tournament.Id);
            }
            foreach (var roundResult in obj.RoundResults)
            {
                playerType.RoundResults.Add(roundResult.Id);
            }
            return playerType;
        }

        public static Player ConvertFromCompositeType(PlayerType obj)
        {
            Player player = new Player()
            {
                Id = obj.Id,
                AccountBalance = obj.AccountBalance,
                Email = obj.Email,
                Birth = obj.Birth,
                Login = obj.Login,
                Surname = obj.Surname,
                Password = obj.Password,
                FirstName = obj.FirstName,
                Sex = obj.Sex,
                VerifyFlag = obj.VerifyFlag,
                PhoneNumber = obj.PhoneNumber
            };
            return player;
        }
    }
}
