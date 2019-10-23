using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SystemAsset02.Data;
using SystemAsset02.Models;
using SystemAsset02.ViewModel;

namespace SystemAsset02.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly AssetSystemDbContext _assetSystemDbContext;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<AccountInfo> _userManager;

        public AdministrationController(AssetSystemDbContext assetSystemDbContext, 
            RoleManager<IdentityRole> roleManager
            , UserManager<AccountInfo> userManager)
        {
            _assetSystemDbContext = assetSystemDbContext;
            _roleManager = roleManager;
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
        //[Authorize(Roles = "Admin")]
        // [Authorize(Roles = "Client")]       
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Administration");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name

            };
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.User.Add(user.UserName);
                }
            }
            return View(model);



        }
        [HttpPost]
       // [Authorize(Policy = "DeleteRolePolicy")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            //phải check -> nhanh nên ko check
            role.Name = model.RoleName;
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("ListRole");
            }

            return View(model);
        }
        [HttpGet]
       // [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRole(string userId)
        {
            ViewBag.userid = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id={ userId} canot be found  ";
                return View("Not Found");

            }
            var model = new List<UserRolesViewModel>();
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;

                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }
        [HttpPost]
        //[Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRole(List<UserRolesViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            //check null
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.IsSelected).Select(y => y.RoleName));
            return RedirectToAction("EditUser", "Account", new { Id = userId });
        }





        //list role
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public IActionResult ListRole()
        {
            var model = _roleManager.Roles;
            var result = _assetSystemDbContext.Roles.ToList();
            return View(result);

        }





    }
}