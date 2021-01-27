using GameName.Demo.Abstract;
using GameName.Demo.Entity;
using MernisServiceRef;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameName.Demo.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            Console.WriteLine("----------Mernis'e müşteri verileri yollanıyor----------" + "\n" +
                "KPSPublicSoapClient'tan dönen değer doğru ise true, yanlışsa false döner. Ben şuanlık True yaptım..");
            return true;
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.Name.ToUpper(), customer.Surname.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
