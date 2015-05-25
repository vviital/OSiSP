namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// PlayerService
    /// </summary>
    class PlayerService : IPlayerService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<Player> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerService"/> class.
        /// </summary>
        public PlayerService()
        {
            this._repository = new PlayerRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public PlayerType Get(int id)
        {
            Player result = this._repository.GetById(id);
            return PlayerType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PlayerType> GetAll()
        {
            List<Player> entries = (List<Player>)this._repository.GetAll();
            List<PlayerType> result = new List<PlayerType>();
            foreach (var item in entries)
            {
                result.Add(PlayerType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(PlayerType source)
        {
            Player downloadable = PlayerType.ConvertFromCompositeType(source);
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
        public void Add(PlayerType source)
        {
            Player downloadable = PlayerType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
