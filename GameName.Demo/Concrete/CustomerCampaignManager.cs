using GameName.Demo.Abstract;
using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Concrete
{
   public class CustomerCampaignManager : ICustomerCampaingManager
    {
        public void CampaignSaleToCustomer(Campaign campaign, Customer customer)
        {
            Console.WriteLine("----------Müşteriye Satılan Kampanyalar----------");
            Console.WriteLine(campaign.CampaignName + " kampanyası " +customer.Name + " " + customer.Surname + " adlı kişiye satıldı.");
        }
    }
}
