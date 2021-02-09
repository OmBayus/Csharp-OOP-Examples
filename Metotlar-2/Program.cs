using System;

namespace Metotlar_2
{

    class Comment
    {
        public int CommentId {get; set;}
        public string Text { get; set; }
    }

    class Product
    {

        public Product()
        {
            this.id = new Random().Next(100,1000);
            this.Comments = new Comment[3];
        }

        public Product(int id):this()
        {
            this.id = id;
        }

        public Product(int id,string name, double fiyat,bool onay):this(id)
        {
            this.isim = name;
            this.price = fiyat;
            this.onay = onay;
        }


        public int id { get; set; }
        public string isim { get; set; }
        public double price { get; set; }
        public bool onay { get; set; }
        public Comment[] Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Comment{CommentId=1,Text="Güzel"};

            var urun = new Product(121,"elma",3.21,true);

            urun.Comments[0] = c1;

            Console.WriteLine(urun.id);
            Console.WriteLine(urun.isim);
            Console.WriteLine(urun.price);
            Console.WriteLine(urun.onay);
            Console.WriteLine(urun.Comments[0].Text);
        
        }
    }
}
