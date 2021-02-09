using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            
            mylist.Add("merhaba"); //liste sonuna elamanı ekler
            mylist.Add(5);
            mylist.Add(true);
            mylist.Add(5.4);
            mylist.Insert(2,5); // Belirli bir indexe eleman ekler

            mylist.Remove("merhaba"); // belirtilen eleman silinir
            mylist.RemoveAt(1); // Verilen index numarasındaki elaman silinir
            mylist.RemoveRange(0,2); //Verilen index numaraları arasındaki elamanlar silinir.

            ArrayList mylist2 = new ArrayList(){"merhaba",5,true,5.4};

            mylist.InsertRange(1,mylist2); // Verilen index numarasından sonraya liste eklenebilir.

            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }

            ArrayList sayilar = new ArrayList(){10,5,12,4,2,7,2};

            sayilar.Sort(); // Veri tipleri aynı ise sıralanır.
            


        }
    }
}
