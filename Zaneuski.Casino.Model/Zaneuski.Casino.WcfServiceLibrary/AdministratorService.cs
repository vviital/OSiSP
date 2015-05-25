namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// AdministratorService
    /// </summary>
    public class AdministratorService : IAdministratorService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<Administrator> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministratorService"/> class.
        /// </summary>
        public AdministratorService()
        {
            this._repository = new AdministratorRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public AdministratorType Get(int id)
        {
            Administrator result = this._repository.GetById(id);
            return AdministratorType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AdministratorType> GetAll()
        {
            List<Administrator> entries = (List<Administrator>)this._repository.GetAll();
            List<AdministratorType> result = new List<AdministratorType>();
            foreach (var item in entries)
            {
                result.Add(AdministratorType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(AdministratorType source)
        {
            Administrator downloadable = AdministratorType.ConvertFromCompositeType(source);
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
        public void Add(AdministratorType source)
        {
            Administrator downloadable = AdministratorType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
