using System;

namespace Static_App
{

    class Product
    {
        public int id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product {id=1,Name="Iphone 5",Price=2000,IsApproved=true};
            Products[1] = new Product {id=2,Name="Iphone 6",Price=3000,IsApproved=false};
            Products[2] = new Product {id=3,Name="Iphone 7",Price=4000,IsApproved=true};
            Products[3] = new Product {id=4,Name="Iphone 8",Price=5000,IsApproved=true};
            Products[4] = new Product {id=5,Name="Iphone X",Price=6000,IsApproved=true};

        }

        public static Product[] GetProducts(){
            return Products;
        }

        public static Product GetProductById(int id){
            Product product = null;

            foreach(var p in Products)
            {
                if (p.id == id){
                    product = p;
                    break;
                }
            }

            return product;
        }

        public static Product GetProductByName(string name){

            Product product = null;

            foreach(var p in Products){
                if(p.Name.ToLower().Contains(name.ToLower())){
                    product = p;
                    break;
                }
                    
            }

            return product;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductManager.GetProducts();

            foreach ( var p in products){
                Console.WriteLine($"Name: {p.Name} Price: {p.Price}");
            }

            var pr1 = ProductManager.GetProductById(2);
            Console.WriteLine($"Name: {pr1.Name} Price: {pr1.Price}");


            var pr2 = ProductManager.GetProductByName("Iphone");
            Console.WriteLine($"Name: {pr2.Name} Price: {pr2.Price}");
        }
    }
}
