using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(20 , "Furkan kaya");
            Ogrenci.Add(21 , "Kadir kaya");
            Ogrenci.Add(23 , "Emre kaya");
            Ogrenci.Add(22 , "Serap kaya");
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
    }
}
