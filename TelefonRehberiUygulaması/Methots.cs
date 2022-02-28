using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiUygulamasi
{
    public class Methots
    {
        public static void NumaraKaydet(ArrayList rehber)
        {
            Console.WriteLine(" Lütfen isim giriniz             : ");
            string ad = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          : ");
            string soyad = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz : ");
            string telNo = Console.ReadLine();
            Kisi newKisi = new Kisi(ad, soyad, telNo);
            rehber.Add(newKisi);
        }

        public static void NumaraSil(ArrayList rehber)
        
        {
            Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string silinecek = Console.ReadLine().ToUpper();

            foreach (Kisi kisi in rehber)
            {
                string bad =kisi.Ad.ToUpper();
                string bsoyad = kisi.Soyad.ToUpper();
                if (silinecek == bad || silinecek == bsoyad)
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(E/H)",kisi.Ad+" "+kisi.Soyad);
                    string secim = Console.ReadLine();
                    switch (secim.ToUpper())
                    {
                        case "E":
                            rehber.Remove(kisi);
                            break;
                        case "H":
                            Console.WriteLine("İşlem iptal edilmiştir.");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("  * Yeniden denemek için      : (2)");

                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            break;
                        case "2":
                            NumaraSil(rehber);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static void NumaraGuncelle(ArrayList rehber)
        {
            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string guncellenecek = Console.ReadLine().ToUpper();
            foreach (Kisi kisi in rehber)
            {
                string bad = kisi.Ad.ToUpper();
                string bsoyad = kisi.Soyad.ToUpper();
                if (guncellenecek == bad || guncellenecek == bsoyad)
                {
                    string tel = Console.ReadLine();
                    kisi.TelNo = tel;
                }
                else
                {
                    Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                    Console.WriteLine(" * Yeniden denemek için              : (2)");

                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            break;
                        case "2":
                            NumaraGuncelle(rehber);
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        public static void NumaraListele(ArrayList rehber)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**************************");

            foreach (Kisi i in rehber)
            {
                Console.WriteLine("İsim: {0}", i.Ad);
                Console.WriteLine("Soy İsim: {0}", i.Soyad);
                Console.WriteLine("Telefon Numarası: {0}", i.TelNo);
            }
        }

        public static void NumaraAra(ArrayList rehber)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************\n");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");

            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    string aranacak = Console.ReadLine().ToUpper();
                    foreach (Kisi kisi in rehber)
                    {
                        string bad = kisi.Ad.ToUpper();
                        string bsoyad = kisi.Soyad.ToUpper();
                        if (aranacak == bad || aranacak == bsoyad)
                        {
                            Console.WriteLine("İsim: {0}", kisi.Ad);
                            Console.WriteLine("Soy İsim: {0}", kisi.Soyad);
                            Console.WriteLine("Telefon Numarası: {0}", kisi.TelNo);
                        }
                    }
                    break;
                case "2":
                    string aranacakTel = Console.ReadLine().ToUpper();
                    foreach (Kisi kisi in rehber)
                    {
                        string tel = kisi.Soyad.ToUpper();
                        if (aranacakTel == tel)
                        {
                            Console.WriteLine("İsim: {0}", kisi.Ad);
                            Console.WriteLine("Soy İsim: {0}", kisi.Soyad);
                            Console.WriteLine("Telefon Numarası: {0}", kisi.TelNo);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
