using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetSystem01.Data;
using AssetSystem01.Models;
using AssetSystem01.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AssetSystem01.Controllers
{
    [AllowAnonymous]
    public class AdministraionController : Controller
    {
        private readonly AssetSystemDbContext _assetSystemDbContext;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<User> _userManager;

        public AdministraionController(
            RoleManager<IdentityRole> roleManager,
             AssetSystemDbContext assetSystemDbContext,
            UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _assetSystemDbContext = assetSystemDbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public  async  Task <IActionResult> CreateRole(CreateRolesViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administraion");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);

        }
    }
}