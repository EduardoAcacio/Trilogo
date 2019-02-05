using System;
using System.Collections.Generic;
using System.Linq;
using TQL.Domain.Interfaces.Repositories;

namespace TQL.Infra.Data.Repositories 
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected TicketsContext Db = new TicketsContext();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll() => Db.Set<TEntity>();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

    }
}