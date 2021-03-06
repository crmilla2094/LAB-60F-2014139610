﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        TEntity Get(int? Id);

        IQueryable<TEntity> GetEntity();

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
