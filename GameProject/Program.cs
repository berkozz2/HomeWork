using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { IdendityId = 12345, FirstName = "BERK", LastName = "ÖZMENEKŞE", BirthYear = 1993, });

            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager1.Delete(new Gamer { FirstName = "BURAK" });

            Console.WriteLine("---------------------------------------");

            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Campaing {CampaingName = "%50 GTA V indirimi" });
            orderManager.Delete(new Campaing());
            orderManager.Update(new Campaing());
           
        }
    }
}
