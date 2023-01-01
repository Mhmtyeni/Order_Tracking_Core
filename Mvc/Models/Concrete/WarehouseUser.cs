using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class WarehouseUser
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int WarehouseLocationId { get; set; }
        public WarehouseLocation WarehouseLocation { get; set; }
        public DateTime Date { get; set; }
    }
}
