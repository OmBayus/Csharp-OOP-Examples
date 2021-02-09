using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adet: ");
			int adet = int.Parse(Console.ReadLine());

            Product[] urunler = new Product[adet];

            for (int i = 0; i < adet; i++)
            {
                Product urun = new Product();
                Console.Write("Ürün İsmi: ");
                urun.name = Console.ReadLine();
                Console.Write("Fiyatı: ");
                urun.fiyat = float.Parse(Console.ReadLine());
                Console.Write("Açıklaması: ");
                urun.description = Console.ReadLine();

                urunler[i] = urun;
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"Ürün İsmi: {urunler[i].name} Ürün Fiyatı: {urunler[i].fiyat} Ürün Açıklaması: {urunler[i].description}");
            }
        }
    }

    class Product
    {
        public string name { get; set; }

        public float fiyat { get; set; }

        public string description { get; set; }

    }
}
