using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("\n İstediğiniz müşteri başarılı ile eklendi.");
            Console.WriteLine(" Müşteri isim ve soyisim: " + musteri.isim + musteri.soyisim);
            Console.WriteLine(" Müşteri id: " + musteri.id);
            Console.WriteLine(" Müşteri cinsiyet: " + musteri.cinsiyet);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.isim + musteri.soyisim);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.isim + musteri.soyisim);
        }
    }
}
