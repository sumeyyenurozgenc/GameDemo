using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Abstract
{
  public  interface ICustomerCampaingManager
    {
        void CampaignSaleToCustomer(Campaign campaign, Customer customer);
    }
}
