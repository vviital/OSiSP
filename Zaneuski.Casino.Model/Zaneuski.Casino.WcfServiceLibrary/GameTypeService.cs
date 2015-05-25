namespace Zaneuski.Casino.WcfServiceLibrary
{
    using System.Collections.Generic;
    using Zaneuski.Casino.Data;
    using Zaneuski.Casino.Data.Repository;
    using Zaneuski.Casino.Model;

    /// <summary>
    /// GameTypeService
    /// </summary>
    public class GameTypeService : IGameTypeService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly BaseRepository<GameType> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameTypeService"/> class.
        /// </summary>
        public GameTypeService()
        {
            this._repository = new GameTypeRepository(new CasinoContext());
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public GameTypesType Get(int id)
        {
            GameType result = this._repository.GetById(id);
            return GameTypesType.ConvertToCompositeType(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GameTypesType> GetAll()
        {
            List<GameType> entries = (List<GameType>)this._repository.GetAll();
            List<GameTypesType> result = new List<GameTypesType>();
            foreach (var item in entries)
            {
                result.Add(GameTypesType.ConvertToCompositeType(item));
            }
            return result;
        }

        /// <summary>
        /// Updates the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Update(GameTypesType source)
        {
            GameType downloadable = GameTypesType.ConvertFromCompositeType(source);
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
        public void Add(GameTypesType source)
        {
            GameType downloadable = GameTypesType.ConvertFromCompositeType(source);
            this._repository.Add(downloadable);
            this._repository.Save();
        }
    }
}
