using System;
using System.Collections;

namespace TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("Yasemin", "Türk", "05052589632");
            Kisi kisi2 = new Kisi("Burcu", "Sarı", "05054874632");
            Kisi kisi3 = new Kisi("Kübra", "Açar", "05060748963");
            Kisi kisi4 = new Kisi("Ebru", "Türk", "05052598742");
            Kisi kisi5 = new Kisi("Ahmet", "Erkan", "05052512345");

            ArrayList rehber = new ArrayList();
            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);

            string islem;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

            while (true)
            {
                islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        Methots.NumaraKaydet(rehber);
                        break;

                    case "2":
                        Methots.NumaraSil(rehber);
                        break;
                    case "3":
                        Methots.NumaraGuncelle(rehber);
                        break;
                    case "4":
                        Methots.NumaraListele(rehber);
                        break;
                    case "5":
                        Methots.NumaraAra(rehber);
                        break;
                    case "X":
                    case "x":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
