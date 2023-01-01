using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        public ICollection<WorkArea> WorkAreas { get; set; }
        public ICollection<WarehouseUser> WarehouseUsers { get; set; }

        [InverseProperty("AppUser")]
        public ICollection<Order> AppUsers { get; set; }

        [InverseProperty("Operation")]
        public ICollection<Order> Operations { get; set; }

        [InverseProperty("AppUserLog")]
        public ICollection<OrderLog> AppUserLogs { get; set; }

        [InverseProperty("OperationLog")]
        public ICollection<OrderLog> OperationLogs { get; set; }
    }
}
