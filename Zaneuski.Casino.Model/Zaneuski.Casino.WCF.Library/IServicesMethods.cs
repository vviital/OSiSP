using System.Collections.Generic;
using System.ServiceModel;

namespace Zaneuski.Casino.WCF.Library
{
    interface IServicesMethods<TEntity>
        where TEntity : BaseTypeUnit
    {
        [OperationContract]
        TEntity Get(int id);

        [OperationContract]
        IEnumerable<TEntity> GetAll();

        [OperationContract]
        void Update(TEntity id);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Add(TEntity country);
    }
}
