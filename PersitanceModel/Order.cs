using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public Guid ShipperId { get; set; }
        public virtual Shipper Shipper { get; set;}
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public Decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCuntry { get; set; }    
        public virtual ICollection<OrderDetail> OrderDetails{ get; set;}    
    }
}
