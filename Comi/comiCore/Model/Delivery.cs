using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Delivery : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ICollection<SaleOrder> SaleOrders { get; set; }
    }
}