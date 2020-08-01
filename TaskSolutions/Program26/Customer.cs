using System;
using System.Collections.Generic;
using System.Text;

namespace _26BeautySalon
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public CustomerStatus Status { get; set; }
    }
}
