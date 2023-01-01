using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class OrderLog
    {
        public int Id { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialDesc { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? AcceptDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime? NoStockDate { get; set; }

        [ForeignKey("OperationLog")]
        public int OperationId { get; set; }
        public AppUser OperationLog { get; set; }

        [ForeignKey("AppUserLog")]
        public int AppUserId { get; set; }
        public AppUser AppUserLog { get; set; }

        public int StationId { get; set; }
        public Station Station { get; set; }
        public int WarehouseLocationId { get; set; }
        public WarehouseLocation WarehouseLocation { get; set; }
    }
}
