using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using Mvc.Models.Dtos.NavBarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.ViewComponents.NavBarViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly Context Context;
        private UserManager<AppUser> UserManager;
        private AppUser LoggedInUser;
        public NavBarViewComponent(UserManager<AppUser> userManager, Context context)
        {
            UserManager = userManager;
            Context = context;
            
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            NavBarGeneralDto navbarModel = new NavBarGeneralDto();
            LoggedInUser = UserManager.GetUserAsync(HttpContext.User).Result;
            AppUser user = await Context.Users.Where(x => x.Id == LoggedInUser.Id).Include(x => x.Factory).FirstOrDefaultAsync();
            navbarModel.users.Add(user);
            if (User.IsInRole("Warehouse"))
            {
                if (!navbarModel.users[0].Factory.Name.Contains("KMF"))
                    navbarModel.worksAreas = await Context.WorkAreas.Where(x => x.AppUserId == LoggedInUser.Id).Include(x=>x.SubLine).ThenInclude(x=>x.AssemblyLine).ToListAsync();
                else
                    navbarModel.wareHouseUsers = await Context.WarehouseUsers.Where(x => x.AppUserId == LoggedInUser.Id).Include(x=>x.WarehouseLocation).ToListAsync();
            }
            else if (User.IsInRole("TV"))
                navbarModel.assemblyLines = await Context.AssemblyLines.Where(x => x.FactoryId == LoggedInUser.FactoryId).ToListAsync();

            return View("_navBar", navbarModel);
        }
    }
}
