﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class Country : Entity
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Code3 { get; set; }

        public bool IsBillingEnabled { get; set; }

        public bool IsShippingEnabled { get; set; }

        public bool IsCityEnabled { get; set; } = true;

        public bool IsZipCodeEnabled { get; set; } = true;

        public bool IsDistrictEnabled { get; set; } = true;
        public virtual ICollection<StateOrProvince> StateOrProvinces { get; set; }
    }
}
