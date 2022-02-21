using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : "+ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

        }
    }
}
