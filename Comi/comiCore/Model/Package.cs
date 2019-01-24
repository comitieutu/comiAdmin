using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Package : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
