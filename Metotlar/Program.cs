using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "ayakkabı";
            urun1.Fiyati = 95;
            urun1.Acıklama = "deri ayakkabı";
            urun1.StokAdedi = 54;

            Urun urun2 = new Urun();
            urun2.Adi = "pantolon";
            urun2.Fiyati = 80;
            urun2.Acıklama = "kot pantolon";
            urun2.StokAdedi = 67; ;

            Urun urun3 = new Urun();
            urun3.Adi = "gözlük";
            urun3.Fiyati = 55;
            urun3.Acıklama = "güneş gözlüğü";
            urun3.StokAdedi = 22;

            Urun[] urunler = new Urun[] {urun1 , urun2 , urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);

                Console.WriteLine(urun.Fiyati);

                Console.WriteLine(urun.Acıklama);

                Console.WriteLine(urun.StokAdedi);

                Console.WriteLine("-------------");
                
            }
            Console.WriteLine("-------------metotlar-------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu" , 20 , 35);
        }
    }
}
