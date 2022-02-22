using System;

namespace HazırMetotlarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz:";
            string degisken2 = "Dersimiz CSharp ";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,false)); //0,1,-1  //false->büyük küçük harf duyarlı

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));

            //EndsWith
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz:"));

            //StartsWith
            Console.WriteLine(degisken.StartsWith("Dersimiz"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Yasemin"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
