using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri Musteri)
        {
            Console.WriteLine("{0} {1}, kayıtlarımıza eklendi!", Musteri.Ad, Musteri.SoyAd);

        }

        public void Listele(Musteri[] Musteriler)
        {
            Console.WriteLine("\tAdı\t\tSoyadı\t\tEposta\t\t\t\tŞehir");
            for (int i = 0; i < Musteriler.Length; i++)
            {
                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}", Musteriler[i].Ad, Musteriler[i].SoyAd, Musteriler[i].Eposta, Musteriler[i].Sehir);
            }

        }

        public void Sil(Musteri Musteri)
        {
            Console.WriteLine("{0} {1}, adlı müşteri kaydı silindi!", Musteri.Ad, Musteri.SoyAd);
        }

    }
}
