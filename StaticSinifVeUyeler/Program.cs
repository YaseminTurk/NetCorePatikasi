using System;

namespace StaticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0} ",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Yasemin","Türk","IK");
            Console.WriteLine("Çalışan Sayısı : {0} ", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Yeşim", "Kaya", "Yazılım");
            Calisan calisan2 = new Calisan("Ebru", "Türk", "Donanım");
            Console.WriteLine("Çalışan Sayısı : {0} ", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Cikar(400,200));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string Isim;
        private string SoyIsim;
        private string Departman;

        public static int CalisanSayisi { get=>calisanSayisi; }

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
