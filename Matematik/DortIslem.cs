using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        { 
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuç : " + toplam);
        }
        public void çarp(int a, int b)
        {
            int çarp = a*b;
            Console.WriteLine("sonuç : " + çarp);
        }
    }
}
