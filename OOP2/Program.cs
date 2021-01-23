using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alperen Mutlu
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123450";
            musteri1.Adi = "Alperen";
            musteri1.SoyAdi = "Mutlu";
            musteri1.TcNo = "11111111111";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID (L) birbirine benziyor müşteriler diye inheritance yapma!

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);



        }
    }
}
