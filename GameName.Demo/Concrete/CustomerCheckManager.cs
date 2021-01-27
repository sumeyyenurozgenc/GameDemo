using GameName.Demo.Abstract;
using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameName.Demo.Concrete
{
   public class CustomerCheckManager : ICustomerCheckService
    {
       public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
