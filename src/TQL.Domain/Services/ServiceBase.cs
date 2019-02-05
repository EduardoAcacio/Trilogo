using System;
using System.Collections.Generic;
using TQL.Domain.Interfaces.Repositories;
using TQL.Domain.Interfaces.Services;

namespace TQL.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
    }
}