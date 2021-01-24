using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Emre";
            customer1.Surname = "Pelvan";
            customer1.IdentityNo = "11111111111";
            customer1.CustomerNo = "1234";
            customer1.PhoneNumber = "05321112233";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Fatma";
            customer2.Surname = "Uğurlu";
            customer2.IdentityNo = "22222222222";
            customer2.CustomerNo = "4321";
            customer2.PhoneNumber = "05331112233";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Kerem";
            customer3.Surname = "Doğan";
            customer3.IdentityNo = "33333333333";
            customer3.CustomerNo = "5678";
            customer3.PhoneNumber = "05341112233";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("-----------------------------");

            customerManager.List(customers);

            Console.WriteLine("---------------------------");

            customerManager.Delete(customer1);
        }
    }
}
