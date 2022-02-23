using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            //her iki grubun kendi içerisinde ortalamalarını alan 
            //ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            Console.WriteLine("20 tane sayı giriniz: ");
            int item;
            ArrayList arrayList = new ArrayList();
            ArrayList maxNumber = new ArrayList();
            ArrayList minNumber = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                item = Convert.ToInt32(Console.ReadLine());
                if (item > 0)
                    arrayList.Add(item);
            }

            arrayList.Sort();

            for (int i = 0;i< 3; i++)
            {
                minNumber.Add(arrayList[i]);
            }
            for (int i = arrayList.Count-3; i < arrayList.Count; i++)
            {
                maxNumber.Add(arrayList[i]);
            }

            int minSum = 0, maxSum = 0;
            int maxCount = maxNumber.Count;
            int minCount = minNumber.Count;

            foreach (int i in maxNumber)
            {
                maxSum += i;
            }

            foreach (int i in minNumber)
            {
                minSum += i;
            }
            
            Console.WriteLine("En büyük 3 sayının ortalaması : " + (maxSum / maxCount));
            Console.WriteLine("En küçük 3 sayının ortalaması : " + (minSum / minCount));
            Console.WriteLine("Toplam ortalama : " + ((minSum / minCount)+ (maxSum / maxCount)));

        }
    }
}
