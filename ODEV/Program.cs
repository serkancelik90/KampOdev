using System;

namespace ODEV
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Ahmet";
            customer1.Soyad = "Öztürk";
            customer1.Id = 4;

            Customer customer2 = new Customer();
            customer2.Ad = "Ali";
            customer2.Soyad = "Demir";
            customer2.Id = 5;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            Console.WriteLine("------------------");

            Console.WriteLine("MÜŞTERİLER :");
            customerManager.List();
        }
    }
}
