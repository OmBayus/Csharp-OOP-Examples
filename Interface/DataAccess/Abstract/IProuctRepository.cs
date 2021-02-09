using System;
using Interface.Entity;

namespace Interface.DataAccess.Abstract
{
      public interface IProductRepository:IRepository<Product>
      {
            Product[] GetProductsByCategory(int id);
      }
}
