using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ıhtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            esnafKrediManager.Hesapla();
            //yani yukarıdan burdan anlıyoruz ki Interface onu implemente(uygulayan) eden classın referansını tutabilir.

            Console.WriteLine("-------------------");

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerServive = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, databaseLoggerService, smsLoggerServive);
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService , smsLoggerServive);
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService, smsLoggerServive);   
            basvuruManager.BasvuruYap(esnafKrediManager, fileLoggerService , smsLoggerServive );


            //bu kısım işimizi kolaylaştırır başvuru manager class'ı açıp içerisine IKrediManager Interfacesini yazdık
            //böyelelikle başvuru yapacağımız zaman kredileri tek tek yazmamıza gerek yoktur yukarıdaki gibi 
            //BasvuruYap diyerek hangi krediyi istiyorsak oraya başvurabiliriz.

            //bu kısım mülakatlarda karşımıza çıkar çok önemli ve ayırıcı bir bilgidir.
            Console.WriteLine("--------------");

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, konutKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
