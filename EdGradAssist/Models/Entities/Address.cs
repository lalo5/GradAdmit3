﻿using System;
using System.Collections.Generic;

namespace EdGradAssist.Models.Entities
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int? FolderNum { get; set; }

        public Application FolderNumNavigation { get; set; }
    }
}
