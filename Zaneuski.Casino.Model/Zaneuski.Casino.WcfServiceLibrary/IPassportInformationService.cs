namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// IPassportInformationService
    /// </summary>
    [ServiceContract]
    public interface IPassportInformationService
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]
        PassportInformationType Get(int id);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        IEnumerable<PassportInformationType> GetAll();

        /// <summary>
        /// Updates the specified country type.
        /// </summary>
        /// <param name="countryType">Type of the country.</param>
        [OperationContract]
        void Update(PassportInformationType countryType);

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
        void Add(PassportInformationType country);
    }

    /// <summary>
    /// PassportInformationType
    /// </summary>
    [DataContract]
    public class PassportInformationType
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
        /// Gets or sets the passport number.
        /// </summary>
        /// <value>
        /// The passport number.
        /// </value>
        [DataMember]
        public string PassportNumber { get; set; }

        /// <summary>
        /// Gets or sets the nationality.
        /// </summary>
        /// <value>
        /// The nationality.
        /// </value>
        [DataMember]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        [DataMember]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the player identifier.
        /// </summary>
        /// <value>
        /// The player identifier.
        /// </value>
        [DataMember]
        public int PlayerId { get; set; }

        /// <summary>
        /// Converts the type of to composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts the type of from composite.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
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
