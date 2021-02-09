using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> plakalar = new Dictionary<int, string>();

            plakalar.Add(34,"İstanbul");
            plakalar.Add(35,"İzmir");
            plakalar.Add(53,"Rize");
            plakalar.Add(61,"Trabzon");


            Dictionary<int,string> sayilar = new Dictionary<int, string>(){
                {1,"bir"},
                {2,"iki"},
                {3,"üç"}
            };

            foreach (var item in plakalar)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            for (int i = 0; i < plakalar.Count; i++)
            {
                Console.WriteLine($"{plakalar.Keys.ElementAt(i)} {plakalar.Values.ElementAt(i)}");
            }

            Console.WriteLine(plakalar.ContainsKey(34)); // true

            Console.WriteLine(plakalar.Contains(new KeyValuePair<int, string>(34,"fırat"))); // false

            plakalar.Remove(34);

            Hashtable ht = new Hashtable(){
                {1,"omer"}
            };

            ht.Add(2,"firat");
            ht.Add("3",3);
            ht.Add("4","furkkan");



            
        }
    }
}
