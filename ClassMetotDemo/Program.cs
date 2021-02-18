using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Abdullah";
            musteri.Soyad = "KIR";
            musteri.Eposta = "abdullahkir@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Fatih";
            musteri2.Soyad = "KIR";
            musteri2.Eposta = "fatihkir@hotmail.com";

            Musteri[] musteriListe = new Musteri[] { musteri, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Silme(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriListe);

            Console.ReadKey();
        }
    }
}
