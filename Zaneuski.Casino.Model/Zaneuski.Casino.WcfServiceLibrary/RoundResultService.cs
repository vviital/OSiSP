namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// RoundResultService
    /// </summary>
    public class RoundResultService : IRoundResultService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<RoundResult> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundResultService"/> class.
        /// </summary>
        public RoundResultService()
        {
            this._repository = new RoundResultRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public RoundResultType Get(int id)
        {
            RoundResult result = this._repository.GetById(id);
            return RoundResultType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoundResultType> GetAll()
        {
            List<RoundResult> entries = (List<RoundResult>)this._repository.GetAll();
            List<RoundResultType> result = new List<RoundResultType>();
            foreach (var item in entries)
            {
                result.Add(RoundResultType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(RoundResultType source)
        {
            RoundResult downloadable = RoundResultType.ConvertFromCompositeType(source);
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
        public void Add(RoundResultType source)
        {
            RoundResult downloadable = RoundResultType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
