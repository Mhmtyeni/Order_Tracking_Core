using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class BaseController : Controller
    {

        public BaseController(UserManager<AppUser> userManager, Context context)
        {
            UserManager = userManager;
            Context = context;
        }
        protected readonly Context Context;
        protected UserManager<AppUser> UserManager { get; }
        protected AppUser LoggedInUser => UserManager.GetUserAsync(HttpContext.User).Result;
    }
}
