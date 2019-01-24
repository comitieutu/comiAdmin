namespace ComiCore.Model
{
    public class Warehouse : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
