using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public virtual ICollection<Product> Products { get; set;}
    }
}
