using System.Collections.Generic;

namespace ComiCore.Model
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDes { get; set; }       
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string DesDetail { get; set; }
        public string Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FlashSaleProduct> FlashSaleProducts { get; set; }
    }
}
