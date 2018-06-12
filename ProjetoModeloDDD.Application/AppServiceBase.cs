using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _servicebase;

        public AppServiceBase(IServiceBase<TEntity> servicebase)
        {
            _servicebase = servicebase;
        }

        public void Add(TEntity obj)
        {
            _servicebase.Add(obj);
        }

        public void Dispose()
        {
            _servicebase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _servicebase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _servicebase.GetById(id);
        }

        public void Remover(TEntity obj)
        {
            _servicebase.Remover(obj);
        }

        public void Update(TEntity obj)
        {
            _servicebase.Update(obj);
        }
    }
}
