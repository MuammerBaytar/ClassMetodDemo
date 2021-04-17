using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ömer";
            musteri1.Soyad = "Adıgüzel";
            musteri1.Tcno = "45678945612";
            musteri1.Sehir = "Kreuzberg";
            
           

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Semih";
            musteri2.Soyad = "Bayram";
            musteri2.Tcno = "25672355612";
            musteri2.Sehir = "Van";
            
            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Muammer";
            musteri3.Soyad = "Baytar";
            musteri3.Tcno = "33578945612";
            musteri3.Sehir = "Newyork";
            
            

            Musteri[] musteriler = new Musteri[] {musteri1 , musteri2 ,musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Tcno);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine("\n");
            }
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            musteriManager.Sıl(musteri1);
            musteriManager.Sıl(musteri2);
            musteriManager.Sıl(musteri3);




        }
    }
}
