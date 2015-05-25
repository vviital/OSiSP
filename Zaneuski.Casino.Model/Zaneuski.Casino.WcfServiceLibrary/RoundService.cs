namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// RoundService
    /// </summary>
    public class RoundService : IRoundService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<Round> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundService"/> class.
        /// </summary>
        public RoundService()
        {
            this._repository = new RoundRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public RoundType Get(int id)
        {
            Round result = this._repository.GetById(id);
            return RoundType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoundType> GetAll()
        {
            List<Round> entries = (List<Round>)this._repository.GetAll();
            List<RoundType> result = new List<RoundType>();
            foreach (var item in entries)
            {
                result.Add(RoundType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(RoundType source)
        {
            Round downloadable = RoundType.ConvertFromCompositeType(source);
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
        public void Add(RoundType source)
        {
            Round downloadable = RoundType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
