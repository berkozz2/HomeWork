using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bu yaptığımız iki nokta üst üste kısmı sen aynı zamanda bir müşterisin diyoruz. inheritance denir buna. miras yani.
    //Asıl olay şudur müşteride olan özellikler artık tüzel ve gerçek müşteridede vardır denir.

    class Corporate:Customer
    {
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}
