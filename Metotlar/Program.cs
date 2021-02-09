using System;

namespace Metotlar
{

    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void BilgileriYazdir(){
            string otomatikmi = this.Otomatik ? "Evet":"Hayır";
            Console.WriteLine($"Marka: {this.Marka}\nModel: {this.Model}\nRenk: {this.Renk}\nOtomatik mi : {otomatikmi}");
        }

        public void Start(){
            Console.WriteLine("Araba Çalıştı");
        }

        public void Stop(){
            Console.WriteLine("Araba stop edildi.");
        }

        public void Yavasla(){
            Console.WriteLine("Araba Yavasliyor.");
        }
        public void Hizlan(){
            Console.WriteLine("Araba hizlaniyor.");
        }

        public void Menu(){
            string komut = "";

            while (komut != "6")
            {
                Console.Write("Seçiminiz : 1-Start 2-Hızlan 3-Yavaşla 4-Stop 5-Bilgileri Göster 6-Çıkış");
                komut = Console.ReadLine();
                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Hizlan();
                        break;
                    case "3":
                        this.Yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    case "5":
                        this.BilgileriYazdir();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Hatali Tuşlama");
                        break;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Araba opel = new Araba();
            opel.Marka = "Opel";
            opel.Model = "Astra";
            opel.Renk = "Siyah";
            opel.Otomatik = false;

            //opel.Menu();

            Araba mazda = new Araba(){
                Marka = "Mazda",
                Model = "CX3",
                Renk = "Beyaz",
                Otomatik = true
            };

            mazda.Menu();


        }
    }
}
