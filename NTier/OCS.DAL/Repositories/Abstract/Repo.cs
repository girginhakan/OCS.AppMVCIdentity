using Microsoft.EntityFrameworkCore;
using OCS.DAL.Data;
using OCS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Repositories.Abstract
{
    public abstract class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseEntity
    {
        protected OCSDbContext _dbContext;

        protected Repo(OCSDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;
        }

        public int Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public TEntity? Get(int id)
        {
            return _dbContext.Set<TEntity>().AsNoTracking().SingleOrDefault(e=>e.Id==id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public int Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
