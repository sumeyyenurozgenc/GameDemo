using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Abstract
{
   public  interface ICampaignService
    {
        void Add_Campaign(Campaign campaign);
        void Update_Campaign(Campaign campaign);
        void Delete_Campaign(Campaign campaign);
        void Get_All_Campaign(Campaign[] campaign);
    }
}
