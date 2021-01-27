using GameName.Demo.Adapters;
using GameName.Demo.Concrete;
using GameName.Demo.Entity;
using System;

namespace GameName.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer()
            {
                Id = 1,
                NationalityId = "12465995576",
                Name = "Sümeyye Nur",
                Surname = "Özgenç",
                DateOfBirth = new DateTime(1997, 4, 10)
            };


            Customer customer2 = new Customer()
            {
                Id = 1,
                NationalityId = "1324567756",
                Name = "Seyit",
                Surname = "Can",
                DateOfBirth = new DateTime(2001, 3, 11)
            };

            CustomerService customerService = new CustomerService(new MernisServiceAdapters());
            customerService.Add_Customer(customer1);
            customerService.Add_Customer(customer2);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Tüm kostümlerde %20 indirim...";
            campaign1.Discount = 20;
            Console.WriteLine();

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Epik Kostüm %45 indirimde...";
            campaign2.Discount = 45;
            Console.WriteLine();

            CampaignService campaignService = new CampaignService();
            campaignService.Add_Campaign(campaign1);
            campaignService.Add_Campaign(campaign2);
            Console.WriteLine();

            CustomerCampaignManager customerCampaignManager = new CustomerCampaignManager();
            customerCampaignManager.CampaignSaleToCustomer(campaign1, customer1);
            customerCampaignManager.CampaignSaleToCustomer(campaign2, customer2);





        }
    }
}
