using System;

namespace ComiCore.Model
{
    public class Contract : BaseEntity
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Package Package { get; set; }
    }
}
