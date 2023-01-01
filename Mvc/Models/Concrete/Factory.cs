using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class Factory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<WarehouseLocation> WarehouseLocations { get; set; }

    }
}
