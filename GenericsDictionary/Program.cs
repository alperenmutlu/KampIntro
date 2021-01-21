using System;
using System.Collections.Generic;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> sehirler = new MyDictonary<int, string>();
            sehirler.Add(17, "Çanakkale");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(6, "Ankara");

            foreach (var plaka in sehirler.Key)
            {
                Console.WriteLine(plaka);
            }

            foreach (var sehir in sehirler.Values)
            {
                Console.WriteLine(sehir);
            }

           

            Console.WriteLine(sehirler.Count_Key);
            Console.WriteLine(sehirler.Count_Value);
            
        }
    }
}
