using OrdersManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Employee: BaseDomainEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }

    }
}
