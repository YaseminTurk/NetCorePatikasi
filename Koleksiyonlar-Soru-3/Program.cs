using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            //ve dizinin elemanlarını sıralayan programı yazınız.

            char[] letters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü'};

            Console.Write("Cümle giriniz : ");
            string words = Console.ReadLine();
            ArrayList temp = new ArrayList();
            char[] wordsLetters = words.ToCharArray();

            foreach (var wordLetter in wordsLetters)
            {
                foreach (var letter in letters)
                {
                    if (wordLetter == letter)
                    {
                        temp.Add(wordLetter);
                    }
                }
            }
            temp.Sort();

            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
