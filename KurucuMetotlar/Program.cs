using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Çalışan 1 *******");
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Yasemin";
            calisan1.Soyad = "Türk";
            calisan1.No = 5445;
            calisan1.Departman = "Yazilim";

            calisan1.CalisanBilgileri();

            Console.WriteLine("******** Çalışan 2 *******");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Kübra";
            calisan2.Soyad = "Ayaz";
            calisan2.No = 87354;
            calisan2.Departman = "IK";

            calisan2.CalisanBilgileri();

            Console.WriteLine("******** Çalışan 3 *******");
            Calisan calisan3 = new Calisan("Ayşe","Kara",5435846,"Satın alma");
            calisan3.CalisanBilgileri();

            Console.WriteLine("******** Çalışan 4 *******");
            Calisan calisan4 = new Calisan("Şeyma", "Karadeniz", "Donanım");
            calisan4.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan()
            {

            }
            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(string ad, string soyad, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.Departman = departman;
            }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı: {0}", Ad);
                Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışan Numarası: {0}", No);
                Console.WriteLine("Çalışan Departmanı: {0}", Departman);
            }
        }
    }
}
