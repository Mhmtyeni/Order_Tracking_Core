using Mvc.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Dtos.OrderDtos
{
    public class OrderGeneralDto
    {
        public Order Orders { get; set; }
        public int StationId { get; set; }
        public int AssemblyLineId { get; set; }
        public SubLine SubLine { get; set; }
        public int locationId { get; set; }
        public OrderGeneralDto()
        {
            this.Orders = new Order();
            this.SubLine = new SubLine();

        }
    }
}
