using System;

namespace MyDictionaryHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Customer = new MyDictionary<int, string>();
            Customer.Add(99, "Berk");
            Customer.Add(98, "Özge");            
            Customer.Add(97, "Beril");
            Console.WriteLine("Başarı ile Yeni kayıt Eklendi : ");
            Console.WriteLine(Customer.Count);


        }
    }
}
