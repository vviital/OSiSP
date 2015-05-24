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
    public interface IPassportInformationService
    {
        [OperationContract]
        PassportInformationType Get(int id);

        [OperationContract]
        IEnumerable<PassportInformationType> GetAll();

        [OperationContract]
        void Update(PassportInformationType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(PassportInformationType country);
    }

    [DataContract]
    public class PassportInformationType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PassportNumber { get; set; }

        [DataMember]
        public string Nationality { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public int PlayerId { get; set; }

        public static PassportInformationType ConvertToCompositeType(PassportInformation obj)
        {
            PassportInformationType type = new PassportInformationType()
            {
                Id = obj.Id,
                ExpirationDate = obj.ExpirationDate,
                Nationality = obj.Nationality,
                PassportNumber = obj.PassportNumber,
                PlayerId = obj.Player.Id
            };
            return type;
        }

        public static PassportInformation ConvertFromCompositeType(PassportInformationType obj)
        {
            PassportInformation information = new PassportInformation()
            {
                Id = obj.Id,
                ExpirationDate = obj.ExpirationDate,
                PassportNumber = obj.PassportNumber,
                Nationality = obj.Nationality
            };
            return information;
        }
    }
}
