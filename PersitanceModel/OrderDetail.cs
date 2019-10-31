using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class OrderDetail
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set;}
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set;}
        
        public Double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Double Discount { get; set; }        
    }
}
