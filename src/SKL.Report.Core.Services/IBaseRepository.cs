using System;
using SKL.Report.Core.Models;

namespace SKL.Report.Core.Services
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        TEntity GetById(dynamic id);

        void Update(TEntity entity);

        void Update(TEntity entity, params string[] propertyNames);

        int SaveChanges();
    }
}
