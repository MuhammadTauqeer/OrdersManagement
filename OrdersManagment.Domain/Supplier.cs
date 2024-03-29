﻿using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Supplier : BaseDomainEntity
    {
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set;}
        public string Country { get; set; }
        public string SupplierPhone { get; set;}
    }
}
