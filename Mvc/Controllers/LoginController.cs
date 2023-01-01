using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using Mvc.Models.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class LoginController : BaseController
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, Context context) : base(userManager, context)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserLoginDto p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, false);
                if (result.Succeeded)
                {
                    var user = UserManager.FindByNameAsync(p.UserName).Result;
                    if (user != null)
                    {
                        if (UserManager.IsInRoleAsync(user, "TV").Result)
                        {
                            var assemblyLine = Context.AssemblyLines.Where(x => x.FactoryId == user.FactoryId).FirstOrDefault();
                            return RedirectToAction("Index", "Tv", new { id = assemblyLine.Id });
                        }
                        else
                        {
                            var userFactory = Context.Factories.Where(x => x.Id == user.FactoryId).FirstOrDefault();
                            if (!userFactory.Name.Contains("KMF"))
                            {
                                Context.WorkAreas.RemoveRange(Context.WorkAreas.Where(x => x.AppUserId == user.Id));
                                await Context.SaveChangesAsync();
                                return RedirectToAction("Index", "Choose");
                            }
                            else
                            {
                                if (UserManager.IsInRoleAsync(user, "Supervisor").Result)
                                    return RedirectToAction("Index", "Order");
                                else
                                {
                                    var location = Context.WarehouseUsers.Where(x => x.AppUserId == user.Id).FirstOrDefault();
                                    return RedirectToAction("Index", "Warehouse", new { Id = location.WarehouseLocationId });

                                }
                            }
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı ya da şifre yanlış!");
                    return View();
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
