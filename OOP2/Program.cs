using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abdullah KIR
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Abdullah";
            musteri1.Soyadi = "Kır";
            musteri1.TcNo = "1234567890";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //x Gerçek müşteri - Tüzel müşteri birbirinin yerine asla kullanılamaz
            //inheritance = birbirinin yerine kullanma

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            

        }
    }
}
