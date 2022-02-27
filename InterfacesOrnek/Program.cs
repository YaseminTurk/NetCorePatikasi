using System;

namespace InterfacesOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }

    public interface IOtomobil
    {
        int KacTekerlektenOlusur();
        Marka HangiMarkaninAraci();
        Renk StandartRengiNe();
    }

    public enum Marka
    {
        Ford,
        Toyota,
        Honda
    }
    public enum Renk
    {
        Beyaz,
        Gri
    }

    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }

    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }

    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
