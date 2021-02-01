using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi:" + urun.Acıklama);
            
        }
        

        public void Ekle2(string urunAdi , string aciklama , double fiyat , int StokAdedi)
        {
            Console.WriteLine("tebrikler Sepete Eklendi : " + urunAdi+ ", " + aciklama + ", " + fiyat+ ", " + StokAdedi);
        }
       
        


        

    }
}
