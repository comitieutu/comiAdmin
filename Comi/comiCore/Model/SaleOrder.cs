using System;
using System.Collections.Generic;

namespace ComiCore.Model
{
    public class SaleOrder : BaseEntity
    {
        public string OrderNumber { get; set; }
        public string UserId { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Processing;
        public double DeliveryPrice { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipperId { get; set; }
        public int PaymentId { get; set; }
        public int DeliveryId { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ReceiveProduct ReceiveProduct { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
    public enum OrderStatus
    {
        Processing = 1,
        Shipping = 2,
        Completed = 3
    }
}
