using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi: " + customer.Name + "  " + customer.Surname);
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("Müşteriler: ");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi: " + customer.Name + "  " + customer.Surname);
        }
    }
}
