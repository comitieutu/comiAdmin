namespace ComiCore.Model
{
    public class ProductDetail : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductImage { get; set; }
        public string DesDetail { get; set; }
        public virtual Product Product { get; set; }
    }
}
