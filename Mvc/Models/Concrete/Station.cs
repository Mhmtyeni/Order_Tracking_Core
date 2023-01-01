using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class Station
    {
        public int Id { get; set; }
        public string StationNumber { get; set; }
        public int SubLineId { get; set; }
        public SubLine SubLine { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderLog> OrderLogs { get; set; }
    }
}
