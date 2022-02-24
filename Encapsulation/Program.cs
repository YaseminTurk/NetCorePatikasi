using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Yasemin";
            ogrenci.SoyIsim = "Türk";
            ogrenci.OgrenciNo= 154;
            ogrenci.Sinif = 3;

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Kaya",785,1);

            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olmalıdır.. ");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
                    
            }
        }

        public Ogrenci()
        {

        }
        public Ogrenci(string isim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("********** Öğrenci Bilgileri **********");
            Console.WriteLine("Öğrenci Adı      : {0} ",this.Isim);
            Console.WriteLine("Öğrenci Soyadı   : {0} ",this.SoyIsim);
            Console.WriteLine("Öğrenci Numarası : {0} ",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   : {0} ",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
