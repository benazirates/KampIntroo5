using GameAppHomework.Abstract;
using GameAppHomework.Entities;
using System;

namespace GameAppHomework.Cocreate
{
    class CampaignManager : ICampaignService
    {
        
        public void Add(Campaign campaing)
        {
            Console.WriteLine(campaing.CampaignName+ " yüklendi.");
        }

       

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " silindi.");
        }

        

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " güncellendi.");
        }

        
    }




}
