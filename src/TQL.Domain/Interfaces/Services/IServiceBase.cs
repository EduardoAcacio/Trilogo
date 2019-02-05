using System.Collections.Generic;

namespace TQL.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Add(TEntity obj);

        void Dispose();
    }
}