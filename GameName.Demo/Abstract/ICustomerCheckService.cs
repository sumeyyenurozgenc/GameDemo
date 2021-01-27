using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameName.Demo.Abstract
{
    public interface ICustomerCheckService
    {
      bool CheckIfRealCustomer(Customer customer);
    }
}
