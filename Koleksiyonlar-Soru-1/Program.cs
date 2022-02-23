using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            bool isPrime(int sayi)
            {
                int count = 0;
                for (int i = 2; i <= sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("20 tane sayı giriniz: ");
            int item;
            ArrayList arrayList = new ArrayList();
            ArrayList primeNumber = new ArrayList();
            ArrayList nonPrimeNumber = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                item = Convert.ToInt32(Console.ReadLine());
                if(item>0)
                    arrayList.Add(item);
            }

            foreach (int i in arrayList)
            {
                if (isPrime(i))
                {
                    primeNumber.Add(i);
                }
                else
                {
                    nonPrimeNumber.Add(i);
                }
            }

            primeNumber.Sort();
            nonPrimeNumber.Sort();
            arrayList.Sort();

            primeNumber.Reverse();
            nonPrimeNumber.Reverse();
            arrayList.Reverse();



            

            int primeSum = 0, nonPrimeSum = 0;
            int primeCount = primeNumber.Count;
            int nonPrimeCount = nonPrimeNumber.Count;

            foreach (int i in primeNumber)
            {
                primeSum += i;
            }

            foreach (int i in nonPrimeNumber)
            {
                nonPrimeSum += i;
            }

            Console.WriteLine("Asal sayıların ortalaması : " + (primeSum / primeCount));
            Console.WriteLine("Asal olmayan sayıların ortalaması : " + (nonPrimeSum / nonPrimeCount));

        }
    }
}
