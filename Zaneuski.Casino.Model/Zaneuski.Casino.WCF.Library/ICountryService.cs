using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Zaneuski.Casino.WCF.Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface ICountryService : IServicesMethods<CountryType>
    {
        // Create
        // Read
        // Update
        // Delete

        CountryType Get(int id)
        {
            
        }

        IEnumerable<CountryType> GetAll();

        void Update(CountryType id);

        void Delete(int id);

        void Add(CountryType country);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Zaneuski.Casino.WCF.Library.ContractType".
    [DataContract]
    public class CountryType : BaseTypeUnit
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CountryName { get; set; }
    }
}
