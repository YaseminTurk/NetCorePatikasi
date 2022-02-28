using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Uygulamasi
{
    public class Operations
    {
        public static void Start()
        {
            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("  *******************************************");
            Console.WriteLine("  (1) Board Listelemek");
            Console.WriteLine("  (2) Board'a Kart Eklemek");
            Console.WriteLine("  (3) Board'dan Kart Silmek");
            Console.WriteLine("  (4) Kart Taşımak");
        }
        public static string EnumToSize(int number)
        {
            if (number == 1)
            {
                return CardSizeEnumModel.XS.ToString();
            }
            else if (number == 2)
            {
                return CardSizeEnumModel.S.ToString();
            }
            else if (number == 3)
            {
                return CardSizeEnumModel.M.ToString();
            }
            else if (number == 4)
            {
                return CardSizeEnumModel.L.ToString();
            }
            else
            {
                return CardSizeEnumModel.XL.ToString();
            }
        }
    }
}
