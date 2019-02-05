using System;
using System.Collections.Generic;
using TQL.Application.Services;
using TQL.Domain.Interfaces.Services;

namespace TQL.Application.App
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

         public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}