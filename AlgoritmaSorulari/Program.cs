using System;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru1();
            Soru2();
            Soru3();
            Soru4();

        }

        private static void Soru4()
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            string[] array = cumle.Split(" ");
            Console.WriteLine("Toplam kelime sayısı : {0}", array.Length);

            string yeniCumle = String.Join("", array);
            Console.WriteLine("Toplam harf sayısı : {0}", yeniCumle.Length);
        }

        private static void Soru3()
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi giriniz : ", i + 1);
                string word = Console.ReadLine();
                array[i] = word;
            }
            foreach (var words in array)
            {
                Console.WriteLine(words);
            }
        }

        private static void Soru2()
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pozitif bir sayı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. pozitif sayıyı giriniz : ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == m || array[i] % m == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        private static void Soru1()
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Pozitif bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}. pozitif sayıyı giriniz : ", i + 1);
                    int number = Convert.ToInt32(Console.ReadLine());
                    array[i] = number;
                }
                for (int j = 0; j < n; j++)
                {
                    if (array[j] % 2 == 0)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
            }
        }
    }
}
