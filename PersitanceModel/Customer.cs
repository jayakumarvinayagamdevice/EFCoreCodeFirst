using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
 
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerCustomerDemograph> CustomerCustomerDemographs { get; set;}
    }
}
