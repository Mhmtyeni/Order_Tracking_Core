using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OrderLog> OrderLogs { get; set; }
    }
}
