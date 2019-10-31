using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class CustomerDemoGraphic
    {
        public Guid CustomerTypeId { get; set; }
        public string CustomerDescription { get; set; }
        public virtual ICollection<CustomerCustomerDemograph> CustomerCustomerDemographs { get; set;}
    }
}
