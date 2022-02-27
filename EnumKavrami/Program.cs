using System;

namespace EnumKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için hava biraz daha sıcak olmalı. ");
            }
            else if(sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün. ");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Dışarıya çıkalım. ");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSıcak=30
    }
}
