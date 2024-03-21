using System;

namespace CoffeeManager
{
    partial class Program
    {
        public class Order
        {
            public int ID { get; set; }
            public int CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public string OrderDetails { get; set; }
        }
    }
}





