using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz dizimi
            //class SinifAdi
            //{
            //    [erişim belirleyici] [veri tipi] özellikAdi;
            //    [erişim belirleyici] [geri dönüş tipi] MetotAdi(parametre listesi);
            //}

            //Erişim Belirleyiciler
            // *public
            // *private
            // *interval
            // *protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Yasemin";
            calisan1.Soyad = "Türk";
            calisan1.No = 5445;
            calisan1.Departman = "Yazilim";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Kübra";
            calisan2.Soyad = "Ayaz";
            calisan2.No = 87354;
            calisan2.Departman = "IK";

            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı: {0}",Ad);
                Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
                Console.WriteLine("Çalışan Numarası: {0}",No);
                Console.WriteLine("Çalışan Departmanı: {0}",Departman);
            }
        }
    }
}
