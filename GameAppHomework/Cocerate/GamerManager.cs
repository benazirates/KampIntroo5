using GameAppHomework.Abstract;
using GameAppHomework.Entities;
using System;

namespace GameAppHomework.Cocreate
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
                Console.WriteLine("Kayıt başarılı.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
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
    }




}
