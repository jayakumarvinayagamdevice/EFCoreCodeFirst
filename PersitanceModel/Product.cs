using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set;}
        public Decimal QuantyPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitInOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public int Discount { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails{ get; set;}
    }
}
