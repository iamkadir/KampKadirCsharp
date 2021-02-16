using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];                   
            isimler[4] = "İlker";                                                                                                                  
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            ///şimdi böyle yapıp yeni bir eleman ekleyebiliriz
            ///ancak sonradan dizinin 0,1,2 ve 3. elemanın tekrar yazdırmak istesek yazdıramayız
            /// çünkü böyle yapınca 5 karaktereli bir dizi tanımlamış gibi oluyoruz alt satıra geçip 4.elemanı yazdırıyoruz
            /// 0,1,2 ve 3 ü de yazdırabiliriz fakat boş karakter olarak yazdırır
            /// yani böyle yaparak ilk dizideki tanımladıgımız degerleri kaybederiz
            /// bu yüzden koleksiyonlar var. Koleksyonlar sayesinde yeni degerler ekleyebiliriz aşağıda ki gibi

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
