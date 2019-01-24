using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Payment : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
