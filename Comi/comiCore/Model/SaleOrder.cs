using System;
using System.Collections.Generic;

namespace ComiCore.Model
{
    public class SaleOrder : BaseEntity
    {
        public string UserId { get; set; }
        public bool OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ShippedDate { get; set; }
        public bool Payment { get; set; }
        public int ShipperId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
