using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialDesc { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? AcceptDate { get; set; }

        [ForeignKey("Operation")]
        public int OperationId { get; set; }
        public AppUser Operation { get; set; }

        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int StationId { get; set; }
        public Station Station { get; set; }
        public int WarehouseLocationId { get; set; }
        public WarehouseLocation WarehouseLocation { get; set; }
    }
}
