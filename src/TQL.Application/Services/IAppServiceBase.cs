using System.Collections.Generic;

namespace TQL.Application.Services
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Dispose();

        void Add(TEntity obj);
    }
}