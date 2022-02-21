using System;

namespace DongulerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırır.
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac ; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("*************");
            //1-1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdırır.
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tektoplam++;
                }
                if (i % 2 == 0)
                {
                    cifttoplam++;
                }
            }
            Console.WriteLine("Tek toplam : "+tektoplam);
            Console.WriteLine("Çift toplam : "+cifttoplam);

            //break,continue
            Console.WriteLine("*************");
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
