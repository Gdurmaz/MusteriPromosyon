using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Project.Core.Singleton;

namespace Project.Core.Repository
{
    public class RepositoryBase<T> :SingletonBase,Repository.IRepository<T> where T : class, new()
    {
        private readonly DbSet<T> _table=null; 
        public RepositoryBase()
        {
            _table = _connDb.Set<T>();
        }
        public int Control(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? 0 : _table.Count(filter);
        }
        public int Delete(T t)
        {
            if (t!=null)
            {
                _table.Remove(t);
            }
            return SaveChanges();
        }
        public T Find(int ID)
        {
            return  _table.Find(ID);
        }
        public T Find(Expression<Func<T, bool>> filter = null)
        {
            return _table.FirstOrDefault(filter);
        }
        public int Insert(T t)
        {
            if (t!=null)
            {
                _table.Add(t);
            }
            return SaveChanges();
        }
        public int SaveChanges()
        {
            return _table == null ? throw new ArgumentException("the value of _table can not be a null") : _connDb.SaveChanges();
        }
        public List<T> Select()
        {
            return _table.ToList();
        }
        public List<T> Select(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? Select() : _table.Where(filter).ToList();
        }
        public int Update(T t)
        {
            if (t!=null)
            {
                
            }
            return SaveChanges();
        }
    }
}
