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
    }

    public class Hayvanlar : Canlilar
    {
        public void SuruHalindeHareket()
        {
            Console.WriteLine("Hayvanlar sürüler halinde hareket eder.");
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
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
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
