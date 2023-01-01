using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    [Authorize]
    public class ChooseController : BaseController
    {
        public static string sysFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
        public ChooseController(UserManager<AppUser> userManager, Context context) : base(userManager, context)
        {

        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<SubLine> subAssembly = new List<SubLine>();
            if (User.IsInRole("Warehouse"))
                ViewBag.isWareHouse = "true";
            else
                ViewBag.isWareHouse = "false";
            var assembly = await Context.AssemblyLines.Where(x => x.FactoryId == LoggedInUser.FactoryId).Include(x => x.SubLines).ToListAsync();
            foreach (var sub in assembly)
                foreach (var line in sub.SubLines)
                    subAssembly.Add(line);
            return View(subAssembly);
        }

        [HttpPost]
        public JsonResult LineArea(int[] SubLineId)
        {
            for (int i = 0; i < SubLineId.Length; i++)
            {
                WorkArea tempArea = new WorkArea();
                tempArea.SubLineId = SubLineId[i];
                tempArea.AppUserId = LoggedInUser.Id;
                DateTime myDate = DateTime.Now;
                tempArea.Date = DateTime.Parse(myDate.ToString(sysFormat));
                Context.WorkAreas.Add(tempArea);
            }
            Context.SaveChanges();
            return Json(true);
        }
    }
}
