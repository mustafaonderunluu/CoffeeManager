using System;

namespace CoffeeManager
{
    partial class Program
    {
        public class OrderManager
        {
            public void Add(Order order)
            {
                Console.WriteLine("Sipariş eklendi: ID-" + order.ID);
            }
        }
    }
}





