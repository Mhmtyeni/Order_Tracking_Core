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
    public class ListController : BaseController
    {
        public ListController(UserManager<AppUser> userManager, Context context) : base(userManager, context)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> OrderTable()
        {
            var orders = await Context.Orders.Where(x => x.AppUserId == LoggedInUser.Id)
                .Include(x => x.Operation)
                .Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine)
                .OrderByDescending(x => x.OrderDate).ToListAsync();
            return PartialView(orders);
        }
        public async Task<ActionResult> OrderHistory()
        {
            var user = await Context.Users.Where(x => x.Id == LoggedInUser.Id).Include(x => x.Factory).FirstOrDefaultAsync();
            List<OrderLog> tempOrderLog = new List<OrderLog>();
            if (User.IsInRole("Warehouse") && user.Factory.Name.Contains("KMF"))
            {
                var tempWorkArea = await Context.WarehouseUsers.Where(x => x.AppUserId == LoggedInUser.Id).ToListAsync();
                foreach (var line in tempWorkArea)
                {
                    var temp = await Context.OrderLogs.Where(x => x.WarehouseLocationId == line.WarehouseLocationId).Include(x => x.OperationLog).Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine).ToListAsync();
                    foreach (var order in temp)
                    {
                        tempOrderLog.Add(order);
                    }
                }
                tempOrderLog = tempOrderLog.OrderByDescending(x => x.OrderDate).Where(x => x.OrderDate.Value.Month == DateTime.Now.Month && x.OrderDate.Value.Year == DateTime.Now.Year && x.OrderDate.Value.Day == DateTime.Now.Day).ToList();
            }
            else if (User.IsInRole("Warehouse") && !user.Factory.Name.Contains("KMF"))
            {
                var tempWorkArea = await Context.WorkAreas.Where(x => x.AppUserId == LoggedInUser.Id).ToListAsync();
                foreach (var line in tempWorkArea)
                {
                    var temp = await Context.OrderLogs.Where(x => x.Station.SubLineId == line.SubLineId).Include(x => x.OperationLog).Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine).ToListAsync();
                    foreach (var order in temp)
                    {
                        tempOrderLog.Add(order);
                    }
                }
            }
            else
            {
                tempOrderLog = await Context.OrderLogs.Where(x => x.AppUserId == LoggedInUser.Id).Include(x => x.OperationLog).Include(x => x.Station).ThenInclude(x => x.SubLine).ThenInclude(x => x.AssemblyLine).ToListAsync();
            }
            return View(tempOrderLog);
        }
    }
}
