using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());
        }
    }
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() { return 4; }
        public virtual Renk StandartRengiNe() { return Renk.Beyaz; }
        public abstract Marka HangiMarkaninAraci();
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

    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

    }
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}
