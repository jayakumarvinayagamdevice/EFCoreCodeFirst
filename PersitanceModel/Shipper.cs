using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Shipper
    {
        public Guid ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
