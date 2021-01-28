using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacCrediManager = new IhtiyacCrediManager();
            ICrediManager tasitCrediManager = new TasitCrediManager();
            ICrediManager konutCrediManager = new KonutCrediManager();

            IloggerService databaseLogerService = new DatabaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService();
            IloggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafCrediManager(), new List<IloggerService> { new DatabaseLoggerService(), new SmsLoggerService() });


            //burada hangi krediyi verirsek onun hesaplama kısmı ile hareket edip onun başvurusunu bize yapacaktır.
            //Interfaceleri birbirinin alternatifi olan ama kodları farklı olan durumlarda kullanırız.

            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacCrediManager, tasitCrediManager };


        }
    }
}
