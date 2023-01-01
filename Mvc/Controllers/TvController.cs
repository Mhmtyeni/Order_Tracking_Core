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
    public class TvController : BaseController
    {
        public TvController(UserManager<AppUser> userManager, Context context) : base(userManager, context)
        {
        }

        public ActionResult Index(int id)
        {
            return View();
        }
        public async Task<IActionResult> TvTable(int id)
        {
            var orders = await Context.Orders.Where(x => x.Station.SubLine.AssemblyLineId == id)
                 .Include(x => x.Operation)
                 .Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine)
                 .OrderByDescending(x => x.OrderDate).ToListAsync();
            return PartialView(orders);
        }
    }
}
