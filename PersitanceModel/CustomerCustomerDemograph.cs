using System;

namespace PersitanceModel
{
    public class CustomerCustomerDemograph
    {
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set;}
        public Guid CustomerTypeId { get; set; }
        public virtual CustomerDemoGraphic CustomerDemoGraphic { get; set;}
    }
}
