﻿using System.Linq.Expressions;

namespace Eve.Service
{
    public interface IService<T> where T : class
    {
        public void Commit();
        public void Dispose();
        public void Add(T entity);
        public void Delete(T entity);
        public void Delete(Expression<Func<T, bool>> condition);
        public void Update(T entity);
        public T Get(Expression<Func<T, bool>> condition);
        public T GetById(object id);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null);
    }
}