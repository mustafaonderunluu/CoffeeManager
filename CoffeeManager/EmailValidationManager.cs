namespace CoffeeManager
{
    partial class Program
    {
        public class EmailValidationManager : ICustomerValidationService
        {
            public bool Validate(Customer customer)
            {
                if (customer.Email.Contains("@"))
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
}





