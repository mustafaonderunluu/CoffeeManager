using static CoffeeManager.Program;

namespace CoffeeManager
{
    internal class IdentityValidationManager : IIdentityValidationService
    {
        public bool Validate(Customer customer)
        {
            // Örnek bir kimlik doğrulama mantığı:
            // Müşteri adı "Poyraz Ege" ve soyadı "Tas" ise kimlik doğrulanmış kabul edilsin
            if (customer.FirstName == "Poyraz Ege" && customer.LastName == "Tas" && customer.Email == "poyrazegetas@gmail.com"&&customer.ID==1 && customer.PhoneNumber== "164161")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}









