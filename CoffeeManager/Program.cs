using System;

namespace CoffeeManager
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // CustomerManager ve OrderManager oluşturulması
            var customerManager = new CustomerManager();
            var orderManager = new OrderManager();

            // Müşteri eklemek için örnek bir müşteri nesnesi oluşturulması
            var customer = new Customer
            {
                ID = 1,
                FirstName = "Poyraz Ege",
                LastName = "Tas",
                PhoneNumber = "164161",
                Email = "poyrazegetas@gmail.com"
            };

            // Sipariş eklemek için örnek bir sipariş nesnesi oluşturulması
            var order = new Order
            {
                ID = 1,
                CustomerID = 1,
                OrderDate = DateTime.Now,
                OrderDetails = "Caremal Machiato, Cappuccino"
            };

            // Müşteri ve siparişin eklenmesi
            customerManager.Add(customer);
            orderManager.Add(order);

            // Kimlik doğrulama servisi oluşturulması ve müşterinin doğrulanması
            var emailValidationService = new EmailValidationManager();
            var identityValidationService = new IdentityValidationManager(); // Kimlik doğrulama servisi eklenmesi

            var isEmailValid = emailValidationService.Validate(customer);
            var isIdentityValid = identityValidationService.Validate(customer); // Müşterinin kimliğinin doğrulanması

            // Müşterinin doğrulanması sonuçlarının ekrana yazdırılması
            if (isEmailValid && isIdentityValid) // Hem e-posta hem de kimlik doğrulamasının geçerli olması gerekir
            {
                Console.WriteLine("Müşteri doğrulandı.");
            }
            else
            {
                Console.WriteLine("Müşteri doğrulanamadı.");
            }

            Console.ReadLine();


        }
    }
}









