﻿using OrdersManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Supplier
{
    public class GetSupplierByIdDto: BaseDto
    {
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string SupplierPhone { get; set; }
    }
}
