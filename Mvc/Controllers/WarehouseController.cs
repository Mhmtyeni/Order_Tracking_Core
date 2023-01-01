using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    [Authorize]
    public class WarehouseController : BaseController
    {
        public WarehouseController(UserManager<AppUser> userManager, Context context) : base(userManager, context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> WarehouseTable(int id)
        {
            dynamic orders;
            var user = await Context.Users.Where(x => x.Id == LoggedInUser.Id).Include(x => x.Factory).FirstOrDefaultAsync();
            if (!user.Factory.Name.Contains("KMF"))
                orders = await Context.Orders.Where(x => x.Station.SubLineId == id).Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine).OrderByDescending(x => x.OrderDate).ToListAsync();
            else
                orders = await Context.Orders.Where(x => x.WarehouseLocationId == id).Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine).OrderByDescending(x => x.OrderDate).ToListAsync();
            return PartialView(orders);
        }
    }
}
