using System;
using Interface.DataAccess.Abstract;
using Interface.Entity;

namespace Interface.DataAccess.Concrete
{
      public class MySQLProductDal : IProductRepository
      {
            public void Create(Product entity)
            {
                  Console.WriteLine("MySQLProduct - create");
            }

            public void Delete(Product entity)
            {
                  throw new NotImplementedException();
            }

            public Product GetById(int id)
            {
                  throw new NotImplementedException();
            }

            public Product[] GetProductsByCategory(int id)
            {
                  throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                  throw new NotImplementedException();
            }
      }
}
