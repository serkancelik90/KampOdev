using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " isimli " + customer.Id + " Id numaralı yeni kişi eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " isimli " + customer.Id + " Id numaralı yeni kişi silindi");
        }
        public void List()
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Serkan";
            customer1.Soyad = "Çelik";
            customer1.Id = 1;

            Customer customer2 = new Customer();
            customer2.Ad = "Ayşe";
            customer2.Soyad = "Çelik";
            customer2.Id = 2;

            Customer customer3 = new Customer();
            customer3.Ad = "Samet";
            customer3.Soyad = "Çelik";
            customer3.Id = 3;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Ad + " " + customer.Soyad + " " + customer.Id);
            }

        }

    }
}
