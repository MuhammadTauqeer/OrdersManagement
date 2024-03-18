using OrdersManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Supplier
{
    public class GetSupplierListDto: BaseDto, ISupplierDto
    {
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
    }
}
