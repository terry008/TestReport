using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SKL.Report.Core.Models;

namespace SKL.Report.Core.Services
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ReportDBContext _dbcontext;

        public BaseRepository(ReportDBContext context)
        {
            this._dbcontext = context;
        }
        public void Add(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Add(entity);
        }

        public TEntity GetById(dynamic id)
        {
            return _dbcontext.Set<TEntity>().Find(id);
        }

        public int SaveChanges()
        {
            return _dbcontext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Attach(entity);
            _dbcontext.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Update(TEntity entity, params string[] propertyNames)
        {
            //4.1将 对象 添加到 EF中              
            EntityEntry entry = _dbcontext.Entry<TEntity>(entity);
            //4.2先设置 对象的包装 状态为 Unchanged              
            entry.State = EntityState.Unchanged;
            //4.3循环 被修改的属性名 数组              
            foreach (string proName in propertyNames)
            {
                //4.4将每个 被修改的属性的状态 设置为已修改状态;后面生成update语句时，就只为已修改的属性 更新                  
                entry.Property(proName).IsModified = true;
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
