using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            kurs kurs1 = new kurs();

            kurs1.KursAdi = "c#";
            kurs1.Eğitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 45;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "kotlin";
            kurs2.Eğitmeni = "atıl samancıoğlu";
            kurs2.IzlenmeOranı = 60;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "c++";
            kurs3.Eğitmeni = "sadi evren şeker";
            kurs3.IzlenmeOranı = 75;

            Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Eğitmeni + " " + kurs1.IzlenmeOranı);


            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach ( var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Eğitmeni + " " + kurs.IzlenmeOranı);
            }


            Console.WriteLine("Hello World!");

        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
