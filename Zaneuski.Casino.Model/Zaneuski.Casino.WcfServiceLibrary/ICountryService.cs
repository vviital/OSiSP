namespace Zaneuski.Casino.WcfServiceLibrary
{
    ﻿using System.Collections.Generic;
    ﻿using System.Runtime.Serialization;
    ﻿using System.ServiceModel;
    ﻿using Zaneuski.Casino.Model;

    /// <summary>
    /// ICountryService
    /// </summary>
    [ServiceContract]
    public interface ICountryService
    {
        // Create
        // Read
        // Update
        // Delete

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        CountryType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<CountryType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(CountryType countryType);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [OperationContract]
        void Delete(int id);

        /// <summary>
        /// Adds the specified country.
        /// </summary>
        /// <param name="country">The country.</param>
        [OperationContract]
        void Add(CountryType country);
    }

    /// <summary>
    /// CountryType
    /// </summary>
    [DataContract]
    public class CountryType
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        /// <value>
        /// The name of the country.
        /// </value>
        [DataMember]
        public string CountryName { get; set; }

        /// <summary>
        /// Gets or sets the players identifier.
        /// </summary>
        /// <value>
        /// The players identifier.
        /// </value>
        [DataMember]
        public List<int> PlayersId { get; set; }

        /// <summary>
        /// Gets or sets the admins identifier.
        /// </summary>
        /// <value>
        /// The admins identifier.
        /// </value>
        [DataMember]
        public List<int> AdminsId { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static Country ConvertFromCompositeType(CountryType obj)
        {
            Country country = new Country() { Id = obj.Id, CountryName = obj.CountryName };
            return country;
        }
    }
}