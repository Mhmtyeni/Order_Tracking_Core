using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class WarehouseLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<WarehouseUser> WarehouseUsers { get; set; }
        public ICollection<OrderLog> OrderLogs { get; set; }
    }
}
