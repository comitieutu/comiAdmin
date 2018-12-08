using System;
using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Vendor : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TaxNumber { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
