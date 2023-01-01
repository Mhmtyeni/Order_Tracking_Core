using Mvc.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models.Dtos.NavBarDtos
{
    public class NavBarGeneralDto
    {
        public List<AppUser> users;
        public List<WorkArea> worksAreas;
        public List<AssemblyLine> assemblyLines;
        public List<WarehouseUser> wareHouseUsers;

        public NavBarGeneralDto()
        {
            this.users = new List<AppUser>();
            this.worksAreas = new List<WorkArea>();
            this.assemblyLines = new List<AssemblyLine>();
            this.wareHouseUsers = new List<WarehouseUser>();
        }
    }
}
