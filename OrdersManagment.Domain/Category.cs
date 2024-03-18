using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Category: BaseDomainEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

    }
}
