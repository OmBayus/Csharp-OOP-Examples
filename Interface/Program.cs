using System;
using Interface.DataAccess.Abstract;
using Interface.DataAccess.Concrete;
using Interface.Entity;

namespace Interface
{

      class ProductManger : IProductRepository
      {

        IProductRepository repository;

        public ProductManger(IProductRepository _repository)
        {
            repository = _repository;
        }
        public void Create(Product entity)
        {
                repository.Create(entity);
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

      class Program
    {
        static void Main(string[] args)
        {
            // var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product());

            // var productdal = new ProductManger(new EfProductDal());
            var productdal = new ProductManger(new MySQLProductDal());
            productdal.Create(new Product());
            
        }
    }
}
