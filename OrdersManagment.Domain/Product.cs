using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Product: BaseDomainEntity
    {
        public string ProductName { get; set; }
        public long SupplierID { get; set; }     
        public Supplier Supplier { get; set; }
        public long CategoryID { get; set; }
        public Category Category { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
    }
}
