namespace ComiCore.Model
{
    public class SaleOrderDetail : BaseEntity
    {
        public int SaleOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Discount { get; set; }
        public virtual Product Product { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
    }
}
