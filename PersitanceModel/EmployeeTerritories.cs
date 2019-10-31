using System;

namespace PersitanceModel
{
    public class EmployeeTerritories
    {
        public Guid EmployeeId { get;set; }
        public virtual Employee Employee { get; set;}
        public Guid TerritoryId { get;set; }
        public virtual Territories Territories { get; set;}
    }
}
