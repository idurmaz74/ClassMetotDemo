using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Birinci\t\tÜçüncü\n");
            //Console.WriteLine("\tİkinvi\tDördüncü\n");
            
            //Müşteri bilgilerini oluşturalım
            Musteri Musteri1 = new Musteri { ID = 1, Ad = "ibrahim", SoyAd = "Durmaz", Sehir = "Adana", Eposta = "idmfdtrtg@yahoo.com" };
            Musteri Musteri2 = new Musteri { ID = 2, Ad = "Asi", SoyAd = "Yanak", Sehir = "Mersin", Eposta = "krlrtk@gmail.com" };
            Musteri Musteri3 = new Musteri { ID = 3, Ad = "Vedat", SoyAd = "Major", Sehir = "İstanbul", Eposta = "vmjdghyt@hotmail.com" };

            //Müşterileri diziye aktaralım
            Musteri[] Musteriler = new Musteri[] {Musteri1, Musteri2, Musteri3};
            
            //Müşteriler ile işlemler yapalım
            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekle(Musteri1);
            MusteriManager.Ekle(Musteri2);

            //Müşterileri listeleyelim
            Console.WriteLine("\n**************************MÜŞTERİ LİSTESİ*******************************");
            MusteriManager.Listele(Musteriler);

            //Bir müşteri silme işlemi yapalım
            Console.WriteLine("\n*********************************************************");
            MusteriManager.Sil(Musteri2);

            //Yeni bir müşteri daha oluşturalım
            Musteri Musteri4 = new Musteri { ID = 1, Ad = "Adman", SoyAd = "Hocalı", Sehir = "Kars", Eposta = "adnmnjsuj@mymail.com" };
            Musteriler[Musteriler.Length-1] = Musteri4;

            //Müşterileri tekrar listeleyelim
            Console.WriteLine("\n**************************MÜŞTERİ LİSTESİ*******************************");
            MusteriManager.Listele(Musteriler);
        }
    }
}
