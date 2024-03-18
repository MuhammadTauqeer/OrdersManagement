using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Shipper: BaseDomainEntity
    {
        public string ShipperName { get; set; }
        public string ShipperEmail { get; set;}
        public string ShipperPhone { get; set;}

    }
}
