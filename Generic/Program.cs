using System;
using System.Collections.Generic;

namespace Generic
{
    class Product
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Generic List
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);


            List<string> isimler = new List<string>();
            isimler.Add("ömer");
            isimler.Add("fırat");
            isimler.Add(null);

            List<Product> urunler = new List<Product>(){
                new Product(){Name="iphone 5"},
                new Product(){Name="iphone 6"},
                new Product(){Name="iphone 7 "},
                new Product(){Name="iphone 8"}
            };

            List<Product> urunler2 = new List<Product>(){
                new Product(){Name="samsung 5"},
                new Product(){Name="samsung 6"},
                new Product(){Name="samsung 7 "},
                new Product(){Name="samsung 8"}
            };

            urunler.AddRange(urunler2);

            int count = urunler.Count; //Eleman sayısı

            urunler.Insert(2,new Product(){Name="Yeni Ürün"});

            urunler.RemoveAt(2);

            urunler.Remove(urunler[2]);

            


        }
    }
}
