using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "java";
            string kurs2 = "python";
            string kurs3 = "c#";
            string kurs4 = "kotlin";
            
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = new string[] { "java", "kotlin", "c#", "python" };

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            

        }
        
    }
}
