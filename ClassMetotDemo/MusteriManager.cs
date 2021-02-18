﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kaydınız başarı ile eklenmiştir! Sn." + musteri.Ad + " " + musteri.Soyad);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Kaydınız başarı ile silinmiştir! Sn." + musteri.Ad + " " + musteri.Soyad);
        }
        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Eposta);

            }
        }
    }
}
