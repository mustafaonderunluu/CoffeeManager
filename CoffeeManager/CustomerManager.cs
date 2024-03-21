using System;

namespace CoffeeManager
{
    partial class Program
    {
        // Managers
        public class CustomerManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine("Müşteri eklendi: " + customer.FirstName + " " + customer.LastName);
            }
        }
    }
}





