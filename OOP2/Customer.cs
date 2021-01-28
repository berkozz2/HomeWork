using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bir özellik tutar. iki operasyon tutar.
    //özellik tuttuğumuz yerde operasyon tutamaz. Operasyon tuttuğumuz yerde özellik tutamaz.
    //Bir sayıya sayısal işlem yaptırmayacaksan onu metinsel yazmak tutmak daha iyidir. Stringde tutmak daha iyidir.
    //*** Eğer ki bir nesnede bir değeri kullanmak zorunda görünmüyorsan orada soyutlama hatası yapıyorsun deriz.
    //bu inhertance ile Customer'ı gerçek ve tüzel kişinin ebevyni yaptık.
    class Customer
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
    }
}
