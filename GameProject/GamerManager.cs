using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldunuz.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt olunamadı.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt BAŞARI İLE SİLİNDİ");
            }
            else
            {
                Console.WriteLine("Kayıt Silmek için Doğru FirstName Giriniz.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyun Güncellenmiştir.");
        }
    }
}
