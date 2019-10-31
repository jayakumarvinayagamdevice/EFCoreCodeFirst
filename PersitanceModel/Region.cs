using System;
using System.Collections.Generic;

namespace PersitanceModel
{
    public class Region
    {
        public Guid RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories {get; set;}
    }
}
