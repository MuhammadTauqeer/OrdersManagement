using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Domain
{
    public class Order
    {
        public long OrderID { get; set; }
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public long ShipperID { get; set; }
        public Shipper Shipper { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
