using OCS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Repositories.Abstract
{
    public interface IRepo<TEntity> where TEntity:BaseEntity
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity? Get (int id);

    }
}
