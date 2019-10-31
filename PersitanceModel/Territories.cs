using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Territories
    {
        public Guid TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public Guid RegionId { get; set; }
        public virtual Region Region { get; set;}
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set;}
    }
}
