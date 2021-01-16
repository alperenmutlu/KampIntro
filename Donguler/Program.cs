using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {      
            //Array

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Giriş",
            "Java","Phyton","c#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //foreach- dizi elemanlarını tek tek gezmeye yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
