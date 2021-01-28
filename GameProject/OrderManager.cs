using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Yeni Kampanyalarımız Eklenmiştir." + " ! "  + campaing.CampaingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Süresi Biten Kampanyalar Kaldırılmıştır.");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Mevcut Bazı Kampanyalarımıza Güncelleme Gelmiştir.");
        }
    }
}

