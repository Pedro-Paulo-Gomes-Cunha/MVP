using Domain.Interfaces.IRepositories;
using MasterContas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.Data.Repositories
{
    public class RepositoryBase<TEntity> :IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ContextDB Db = new();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);

            Db.SaveChanges();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;

            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);

            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
