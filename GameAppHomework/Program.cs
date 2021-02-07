using GameAppHomework.Cocreate;
using GameAppHomework.Entities;
using System;

namespace GameAppHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer()
            {
                Id = 8,
                FirstName = "Benazir",
                LastName = "Ateş",
                BirthYear = 1997,
                TcNo = "12369547852"

            };
            gamerManager.Add(gamer);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "TARAFTAR",
                CampaignRate = 45
            };

            Game game = new Game()
            {
                GameByte = 160,
                GameName = "jUMANJİ",
                Price = 50,
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameSellManager gameSellManager = new GameSellManager(campaign, game);
            gameSellManager.sell(gamer, game, campaign);




            Console.WriteLine(); 

        }
    }




}
