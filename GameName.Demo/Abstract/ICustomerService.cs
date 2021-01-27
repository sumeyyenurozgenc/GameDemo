using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Abstract
{
    public interface ICustomerService
    {
        void Add_Customer(Customer customer);
        void Update_Customer(Customer customer);
        void Delete_Customer(Customer customer);
        void Get_All_Customer(Customer[] customers);
    }
}
