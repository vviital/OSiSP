namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// TournamentRestrictionService
    /// </summary>
    public class TournamentRestrictionService : ITournamentRestrictionService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<TournamentRestriction> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentRestrictionService"/> class.
        /// </summary>
        public TournamentRestrictionService()
        {
            this._repository = new TournamentRestrictionRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TournamentRestrictionType Get(int id)
        {
            TournamentRestriction result = this._repository.GetById(id);
            return TournamentRestrictionType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TournamentRestrictionType> GetAll()
        {
            List<TournamentRestriction> entries = (List<TournamentRestriction>)this._repository.GetAll();
            List<TournamentRestrictionType> result = new List<TournamentRestrictionType>();
            foreach (var item in entries)
            {
                result.Add(TournamentRestrictionType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(TournamentRestrictionType source)
        {
            TournamentRestriction downloadable = TournamentRestrictionType.ConvertFromCompositeType(source);
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
        public void Add(TournamentRestrictionType source)
        {
            TournamentRestriction downloadable = TournamentRestrictionType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
