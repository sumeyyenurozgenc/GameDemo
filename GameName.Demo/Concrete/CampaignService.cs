using GameName.Demo.Abstract;
using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Concrete
{
    public class CampaignService : ICampaignService
    {
        public void Add_Campaign(Campaign campaign)
        {
            Console.WriteLine("----------Kampanya Ekleme----------");
            Console.WriteLine(campaign.CampaignName + " adlı kampanya eklendi.");
        }

        public void Delete_Campaign(Campaign campaign)
        {
            Console.WriteLine("----------Kampanya Silme----------");
            Console.WriteLine("Seçilen " + campaign.CampaignName + "  kampanyası silindi");
        }

        public void Get_All_Campaign(Campaign[] campaigns)
        {
            Console.WriteLine("----------Tüm kampanyaları getirme----------");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Kampanya Adı: {0}, Kampanya İndirimi: {1}", campaign.CampaignName, campaign.Discount);
            }
        }

        public void Update_Campaign(Campaign campaign)
        {
            Console.WriteLine("----------Kampanya Güncelleme----------");
            Console.WriteLine(campaign.CampaignName + " " + campaign.Discount + " adlı kampanya güncellendi.");
        }
    }
}
