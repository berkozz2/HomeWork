using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123456";
            customer1.Name = "Berk";
            customer1.LastName = "Yılmaz";
            customer1.TcNo = "9999999999";

            //Kodlama.io

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "654321";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "123456789";

            //Gerçek Müşteri - Tüzel Müşteri ikiside müşteri olsa da bir biri yerine kullanılamaz.
            //Bu yaptığımız IndividualCustomer veya CorporateCustomer'den sonra iki nokta üst üste işaretiyle customer'ı individual ve corporate'in ebeveyn'i yaptık.
            //Customer tek başına daha olsa individual ve corporate customer'i tutabiliyor.
            //Customer3 ve Customer4'te görüldüğü gibi.

            Customer customer3 = new IndividualCustomer(); //Şu anda burada olan durum Gerçek ve Tüzel müşteriyi de tutabiliyor.
            Customer customer4 = new Corporate(); //Böyle bir şekilde yaptığımızda new koduyla ref no veriyoruz. Bu durumda müşteri hem gerçek hem de tüzel müşteri kişiyi tutabiliyor.

            CustomerManager customerManagers = new CustomerManager();
            customerManagers.Add(customer1);
            customerManagers.Add(customer2);


        }
    }
}
