using System;
using System.ComponentModel.DataAnnotations;

namespace ComiCore.Model
{
    public class Contract : BaseEntity
    {
        public string Description { get; set; }
        public Duration Duration { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int VendorId { get; set; }
        public double UnitPrice { get; set; }
        public int PackageId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Package Package { get; set; }
    }
    public enum Duration
    {
        [Display(Name = "Three month")]
        ThreeMonth = 1,
        [Display(Name = "Six month")]
        SixMonth = 2,
        [Display(Name = "One year")]
        OneYear = 3
    }
}
