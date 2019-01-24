using System.Collections.Generic;

namespace ComiCore.Model
{
    public class StateOrProvince : BaseEntity
    {
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}