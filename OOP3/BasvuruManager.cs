using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection -- Burada hangi log olduğu hangi kredilerde yapacağımızı belli ediyoruz burada biz.
        public void BasvuruYap(ICrediManager crediManager, List<IloggerService> loggerServices)
        {
            crediManager.Hesapla();
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
