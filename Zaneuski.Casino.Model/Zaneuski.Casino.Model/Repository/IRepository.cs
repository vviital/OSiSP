using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zaneuski.Casino.Model.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        TEntity Get(int id);

        TEntity Update(TEntity entity);

        TEntity Delete(TEntity entity);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        int Count(Expression<Func<TEntity, bool>> filted);
    }
}
