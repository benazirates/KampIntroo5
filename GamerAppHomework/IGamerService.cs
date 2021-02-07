using GamerAppHomework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerAppHomework
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
    interface IGameSaleAreaService
    {
        void Log();
        void Delete();
        void Update();
    }



}
