namespace ComiCore.Model
{
    public class ReceiveProduct : BaseEntity
    {
        public int SaleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToStreet { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
    }
}
