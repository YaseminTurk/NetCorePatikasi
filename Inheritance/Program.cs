using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Bosaltim();
            //tohumluBitki.Solunum();
            //tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**********************");

            Ordek ordek = new Ordek();
            //ordek.Solunum();
            //ordek.Beslenme();
            //ordek.Bosaltim();
            //ordek.SuruHalindeHareket();
            ordek.Yuzmek();
        }
    }

    //bir class sealed ile işaretlendiyse hiçbir yerden ulaşılamaz. yani kalıtım engellenir.
    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }

    }

    public class Hayvanlar : Canlilar
    {
        public void SuruHalindeHareket()
        {
            Console.WriteLine("Hayvanlar sürüler halinde hareket eder.");
        }
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Kus : Hayvanlar
    {
        public Kus()
        {
            base.SuruHalindeHareket();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }

    public class Ordek : Hayvanlar
    {
        public Ordek()
        {
            base.SuruHalindeHareket();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Yuzmek()
        {
            Console.WriteLine("Ördekler yüzer");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }

    public class Bitkiler : Canlilar
    {
        public void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }


}
