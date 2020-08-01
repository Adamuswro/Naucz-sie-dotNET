using System.Collections.Generic;

namespace _26BeautySalon
{
    internal interface IDataSource
    {
        void SaveCustomer(Customer newCustomer);
        void UpdateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
    }
}