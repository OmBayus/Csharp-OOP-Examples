using System;
using Interface.Entity;

namespace Interface.DataAccess.Abstract
{
      public interface IRepository<TEntity>
      {
            TEntity GetById(int id);

            void Update(TEntity entity);

            void Create(TEntity entity);

            void Delete(TEntity entity);
      }
}
