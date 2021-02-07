using GameAppHomework.Abstract;
using GameAppHomework.Entities;
using System;

namespace GameAppHomework.Cocreate
{
    class GameSellManager : IGameSellService
    {
        public double _campaignPrice;

        public GameSellManager(Campaign campaign, Game game)
        {
            _campaignPrice = (game.Price * campaign.CampaignRate)/100 ;
        }

        

        public void sell(Gamer gamer, Game game, Campaign campaign)
        {
            if(campaign != null)
            {
                Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " adlı oyuncu tarafından " + campaign.CampaignName + " kampanyasıyla " + _campaignPrice + " TL indirimle satın alındı.");
            }
            else
            {
                Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " adlı oyuncu tarafından " + " kampanya kullanılmadan satın alındı.");
            }
        }
    }




}
