namespace ComiCore.Model
{
    public class ReceiveProduct : BaseEntity
    {
        public int SaleId { get; set; }
        public string ShipToName { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToDistrict { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCountry { get; set; }
        public virtual SaleOrder SaleOrder { get; set; }
    }
}
