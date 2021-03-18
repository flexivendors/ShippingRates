﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingRates.Tests
{
    public class TestsConfiguration
    {
        public string USPSUserId { get; set; }

        public string UPSLicenseNumber { get; set; }
        public string UPSUserId { get; set; }
        public string UPSPassword { get; set; }

        public string FedExKey { get; set; }
        public string FedExPassword { get; set; }
        public string FedExAccountNumber { get; set; }
        public string FedExMeterNumber { get; set; }
        public string FedExHubId { get; set; }
        public bool FedExUseProduction { get; set; } = false;

        public string DHLSiteId { get; set; }
        public string DHLPassword { get; set; }
        public string DHLAccountNumber { get; set; }
    }
}
