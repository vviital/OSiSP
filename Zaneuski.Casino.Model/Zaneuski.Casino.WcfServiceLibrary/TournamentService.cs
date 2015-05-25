namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// TournamentService
    /// </summary>
    class TournamentService : ITournamentService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<Tournament> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentService"/> class.
        /// </summary>
        public TournamentService()
        {
            this._repository = new TournamentRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TournamentType Get(int id)
        {
            Tournament result = this._repository.GetById(id);
            return TournamentType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TournamentType> GetAll()
        {
            List<Tournament> entries = (List<Tournament>)this._repository.GetAll();
            List<TournamentType> result = new List<TournamentType>();
            foreach (var item in entries)
            {
                result.Add(TournamentType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(TournamentType source)
        {
            Tournament downloadable = TournamentType.ConvertFromCompositeType(source);
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
        public void Add(TournamentType source)
        {
            Tournament downloadable = TournamentType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
