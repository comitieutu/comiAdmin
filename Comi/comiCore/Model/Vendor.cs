using System;
using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Vendor : BaseEntity
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
