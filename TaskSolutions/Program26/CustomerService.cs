using System;
using System.Collections.Generic;
using System.Text;

namespace _26BeautySalon
{
    class CustomerService : ICustomerService
    {
        readonly IDataSource db;
        public CustomerService(IDataSource db)
        {
            this.db = db;
        }

        public Customer CreateCustomer(CustomerStatus status, string fullName)
        {
            var newCustomer = new Customer() { FullName = fullName, Status = status, Id = Guid.NewGuid() };

            db.SaveCustomer(newCustomer);
            return newCustomer;
        }

        public void ChangeStatus(Customer customer, CustomerStatus newStatus)
        {
            if (customer.Status == newStatus)
            {
                return;
            }
            customer.Status = newStatus;
            db.UpdateCustomer(customer);
        }

        public List<Customer> GetAll()
        {
            List<Customer> result = db.GetAllCustomers();
            return result;
        }


    }
}
