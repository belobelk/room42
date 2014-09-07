using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IRepository
    {
        void Add<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void Add<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity;

        IQueryable<TEntity> All<TEntity>(params string[] includePath) where TEntity : class, IEntity;

        void Delete<TEntity>(object id) where TEntity : class, IEntity;
        void Delete<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void Delete<TEntity>(Expression<Func<TEntity, bool>> predecate) where TEntity : class, IEntity;

        TEntity Single<TEntity>(object key) where TEntity : class, IEntity;
        TEntity Single<TEntity>(Expression<Func<TEntity, bool>> predicate, params string[] includePath) where TEntity : class, IEntity;

        IQueryable<TEntity> Query<TEntity>(Expression<Func<TEntity, bool>> predicate, params string[] includePath) where TEntity : class, IEntity;

    }
}
