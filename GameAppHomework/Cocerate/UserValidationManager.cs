using GameAppHomework.Abstract;
using GameAppHomework.Entities;

namespace GameAppHomework.Cocreate
{
    class UserValidationManager :IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 8 && gamer.BirthYear == 1997 && gamer.FirstName ==
                "Benazir" && gamer.LastName == "Ateş" && gamer.TcNo == "12369547852")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }




}
