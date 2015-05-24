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
    public interface IAdministratorService
    {
        [OperationContract]
        AdministratorType Get(int id);

        [OperationContract]
        IEnumerable<AdministratorType> GetAll();

        [OperationContract]
        void Update(AdministratorType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(AdministratorType country);
    }

    [DataContract]
    public class AdministratorType
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
        public List<int> ObservedPlayers { get; set; }

        [DataMember]
        public List<int> SupervisedTournaments { get; set; }

        [DataMember]
        public int Country { get; set; }

        public static AdministratorType ConvertToCompositeType(Administrator obj)
        {
            AdministratorType type = new AdministratorType()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                Email = obj.Email,
                Country = obj.Country.Id,
                FirstName = obj.FirstName,
                Sex = obj.Sex,
                Login = obj.Login,
                Password = obj.Password,
                Surname = obj.Surname,
                ObservedPlayers = new List<int>(),
                SupervisedTournaments = new List<int>()
            };
            foreach (var observedPlayer in obj.ObservedPlayers)
            {
                type.ObservedPlayers.Add(observedPlayer.Id);
            }
            foreach (var supervisedTournament in obj.SupervisedTournaments)
            {
                type.SupervisedTournaments.Add(supervisedTournament.Id);
            }
            return type;
        }

        public static Administrator ConvertFromCompositeType(AdministratorType obj)
        {
            Administrator administrator = new Administrator()
            {
                Id = obj.Id,
                Birth = obj.Birth,
                Email = obj.Email,
                Login = obj.Login,
                FirstName = obj.FirstName,
                Password = obj.Password,
                Sex = obj.Sex,
                Surname = obj.Surname
            };
            return administrator;
        }
    }
}
