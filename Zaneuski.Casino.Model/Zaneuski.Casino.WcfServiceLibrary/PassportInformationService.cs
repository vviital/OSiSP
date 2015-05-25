namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// PassportInformationService
    /// </summary>
    public class PassportInformationService : IPassportInformationService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<PassportInformation> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PassportInformationService"/> class.
        /// </summary>
        public PassportInformationService()
        {
            this._repository = new PassportInformationRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public PassportInformationType Get(int id)
        {
            PassportInformation result = this._repository.GetById(id);
            return PassportInformationType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PassportInformationType> GetAll()
        {
            List<PassportInformation> entries = (List<PassportInformation>)this._repository.GetAll();
            List<PassportInformationType> result = new List<PassportInformationType>();
            foreach (var item in entries)
            {
                result.Add(PassportInformationType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(PassportInformationType source)
        {
            PassportInformation downloadable = PassportInformationType.ConvertFromCompositeType(source);
            this._repository.Update(downloadable);
            this._repository.Save();
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            this._repository.Delete(o => o.Id == id);
            this._repository.Save();
        }

        /// <summary>
        /// Adds the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Add(PassportInformationType source)
        {
            PassportInformation downloadable = PassportInformationType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
