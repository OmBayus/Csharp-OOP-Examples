using System;
using System.Collections;
using System.Collections.Generic;

namespace ErrorHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Örnek

            // var liste = new List<string>(){"1","2","5a","abc","10","50"};

            // foreach (var i in liste)
            // {
            //     try
            //     {
            //         int a = int.Parse(i);
            //         Console.WriteLine(a);
            //     }
            //     catch (System.Exception)
            //     {
                    
            //     }
                
            // }


            // 2.Örnek

            // while (true)
            // {
            //     Console.Write("Sayi: ");
            //     string deger = Console.ReadLine();


            //     if (deger != "q")
            //     {
            //         try
            //         {
            //             var a = int.Parse(deger);
            //             Console.WriteLine("Bir Sayidir");
            //         }
            //         catch (System.Exception)
            //         {
            //             Console.WriteLine("Sayi Değil");
            //         }
            //     }else{
            //         break;
            //     }
            // }


            // 3.Örnek

            Console.Write("Parola: ");
            string parola = Console.ReadLine();
            bool b = false;

            foreach (var item in parola)
            {
                if (item == 'ğ' || item == 'ı' || item == 'ü' || item == 'ş' || item == 'ö' || item == 'ç')
                {
                    b = true;
                }
            }

            if(b){
                Console.WriteLine("Türkçe Karakter içeriyor");
            }
            else{
                Console.WriteLine("Türkçe Karakter içermiyor");
            }

            
        }
    }
}
