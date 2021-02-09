using System;

namespace Properties
{

    class Product
    {
        private string name;
        private double price;

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value<0){
                    this.price = 0;
                }
                else{
                    this.price = value;
                }
            }
        }

        public string Name 
        { 
            get
            {
                return this.name;
            } 
            set
            {
                if(!string.IsNullOrEmpty(value)){
                    this.name = value;
                }
                else{
                    //Hata Mesajı yollar çünkü boş değer göndermiştir.
                    throw new Exception("Name alanı Boş geçilemez");
                }
            }
        }

        public bool Onaylı { get; } // set Silinirse sadece okunabilir bir obje oluşur.

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();

            pr1.Name = "";

            pr1.Price = -2000;

            Console.WriteLine(pr1.Name);
            Console.WriteLine(pr1.Price);

            pr1.Name = "omer";

            pr1.Price = 120;

            Console.WriteLine(pr1.Name);
            Console.WriteLine(pr1.Price);
        }
    }
}
