using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Survey1.Models;

namespace Survey1.Controllers
{
    public class AdminController : Controller
    {

        private UserManager<AppUser> userManager;

        public AdminController(UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
        }


        public IActionResult Index()
        {
            return View(userManager.Users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();
                user.UserName = model.Password;
                user.Email = model.Email;

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            
            
            return View(model);
        }
    }
}