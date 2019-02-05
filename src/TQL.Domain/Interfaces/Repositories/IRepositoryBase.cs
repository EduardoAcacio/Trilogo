using System.Collections.Generic;

namespace TQL.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> 
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Add(TEntity obj);

        void Dispose();
    }
}
