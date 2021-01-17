using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.isim = " Osman ";
            musteri1.soyisim = " Kılıç ";
            musteri1.id = 5;
            musteri1.cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.isim = " Ahmet ";
            musteri2.soyisim = " Gökyüzü ";
            musteri2.id = 6;
            musteri2.cinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.isim = " Gemma ";
            musteri3.soyisim = " Teller ";
            musteri3.id = 7;
            musteri3.cinsiyet = " Kadın ";

            Musteri musteri4 = new Musteri();
            musteri4.isim = " Batuhan ";
            musteri4.soyisim = " Çelik ";
            musteri4.id = 7;
            musteri4.cinsiyet = " Erkek ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);


            Console.WriteLine("\n");
            Console.WriteLine("Müşteri Listesi: ");
            musteriManager.MusteriListele(musteriler);

            Console.WriteLine("\nSilinen Müşteriler: ");
            musteriManager.MusteriSil(musteri4);
        }
    }
}
