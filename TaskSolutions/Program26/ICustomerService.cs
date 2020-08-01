using System.Collections.Generic;

namespace _26BeautySalon
{
    public interface ICustomerService
    {
        Customer CreateCustomer(CustomerStatus status, string fullName);

        void ChangeStatus(Customer customer, CustomerStatus newStatus);

        List<Customer> GetAll();
    }
}