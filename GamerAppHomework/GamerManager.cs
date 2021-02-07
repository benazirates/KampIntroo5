using System;
using System.Collections.Generic;
using System.Text;

namespace GamerAppHomework
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
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }


        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
        class UserValidationManager : IUserValidationService
        {
            public bool Validate(Gamer gamer)
            {
                if (gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN"
                    && gamer.LastName == "DEMİROĞ" && gamer.IdentityNumber == 12345)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            class GameSaleArea:IGameSaleAreaService
            {
                public void Log()
                {
                    Console.WriteLine("yeni kampanya girişi YAPILDI.");
                }
                public void Delete()
                {
                    Console.WriteLine("kampanya silindi.");
                }
                public void Update()
                {
                    Console.WriteLine("kampanya güncellendi");
                }

                
            }




        }
    }
}
