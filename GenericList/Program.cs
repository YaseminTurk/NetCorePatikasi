using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T->object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu.");
            }


            //Elemanile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));


            //Diziyi List e çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);


            //Liste temizleme
            hayvanListesi.Clear();


            //List içerisinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Yasemin";
            kullanici1.Soyisim = "Turk";
            kullanici1.Yas = 25;
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Nimesay";
            kullanici2.Soyisim = "Turk";
            kullanici2.Yas = 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 23
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine(kullanici.Isim);
            }
            foreach (var kullanici in yeniListe)
            {
                Console.WriteLine(kullanici.Isim+" "+kullanici.Soyisim);
            }
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas ;
        public string Isim { get=>isim; set=>isim=value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
