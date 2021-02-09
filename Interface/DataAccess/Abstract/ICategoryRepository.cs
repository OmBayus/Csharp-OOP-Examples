using System;
using Interface.Entity;

namespace Interface.DataAccess.Abstract
{
      public interface ICategoryRepository:IRepository<Category>
      {
            Category[] GetCategories();
      }
}
