﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
﻿using Zaneuski.Casino.Model;

namespace Zaneuski.Casino.WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICountryService
    {
        // Create
        // Read
        // Update
        // Delete

        [OperationContract]
        CountryType Get(int id);

        [OperationContract]
        IEnumerable<CountryType> GetAll();

        [OperationContract]
        void Update(CountryType countryType);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(CountryType country);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Zaneuski.Casino.WCF.Library.ContractType".
    [DataContract]
    public class CountryType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public List<int> PlayersId { get; set; }

        [DataMember]
        public List<int> AdminsId { get; set; }

        public static CountryType ConvertToCompositeType(Country obj)
        {
            CountryType country = new CountryType() { CountryName = obj.CountryName, Id = obj.Id };
            country.AdminsId = new List<int>();
            country.PlayersId = new List<int>();
            foreach (var item in obj.Administrators)
            {
                country.AdminsId.Add(item.Id);
            }
            foreach (var item in obj.Players)
            {
                country.PlayersId.Add(item.Id);
            }
            return country;
        }

        public static Country ConvertFromCompositeType(CountryType obj)
        {
            Country country = new Country() { Id = obj.Id, CountryName = obj.CountryName };
            return country;
        }
    }
}