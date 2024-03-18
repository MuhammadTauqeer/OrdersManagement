using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class OrderDetail: BaseDomainEntity
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
