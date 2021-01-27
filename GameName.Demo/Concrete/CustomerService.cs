using GameName.Demo.Abstract;
using GameName.Demo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Concrete
{
    public class CustomerService : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerService(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add_Customer(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri gerçek olduğu için sisteme eklendi.\n");
            }
            else
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " adlı Müşteri gerçek olmadığı için sisteme eklenemedi.\n");
            }
        }

        public void Delete_Customer(Customer customer)
        {
            Console.WriteLine(customer.Name, customer.Surname, "{0} {1} adlı kullanıcı silindi.");
        }

        public void Get_All_Customer(Customer[] customers)
        {
            Console.WriteLine("----------Tüm Müşterileri Getirme----------");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        public void Update_Customer(Customer customer)
        {
            Console.WriteLine(customer.Name, customer.Surname, "{0} {1} adlı kullanıcı güncellendi.");
        }
    }
}
