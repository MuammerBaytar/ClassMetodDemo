using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri) 
        {
            Console.WriteLine("Tebrikler Müşteri Eklendi : " + "Adı: " + musteri.Adi + " " + " Soyadı: " +
                musteri.Soyad + " " + " TcNo: " +
                musteri.Tcno + " " + " Şehir: " +
                musteri.Sehir);
            Console.WriteLine("\n");
        }
        public void Listele (Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri Listelendi : " + "Adı: " + musteri.Adi + " " + " Soyadı: " +
                musteri.Soyad + " " + " TcNo: " +
                musteri.Tcno + " " + " Şehir: " +
                musteri.Sehir);
            Console.WriteLine("\n");
        }
        public void Sıl (Musteri musteri)
        {
            Console.WriteLine("Tebrikler Müşteri silindi : " + "Adı: " + musteri.Adi + " " + " Soyadı: " +
                musteri.Soyad+ " " + " TcNo: " +
                musteri.Tcno + " " + " Şehir: " +
                musteri.Sehir);
            Console.WriteLine("\n");
        }
    }
}
