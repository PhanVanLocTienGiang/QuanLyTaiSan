using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SystemAsset02.Common;
using SystemAsset02.Data;
using SystemAsset02.Models;
using SystemAsset02.ViewModel;

namespace SystemAsset02.Controllers
{
    public class AccountController : Controller
    {
        private readonly AssetSystemDbContext _assetSystemDbContext;
        private readonly UserManager<AccountInfo> _userManager;
        private readonly SignInManager<AccountInfo> _signInManager;
        public AccountController(AssetSystemDbContext assetSystemDbContext,
            UserManager<AccountInfo> userManager,
            SignInManager<AccountInfo> signInManager)
        {
            _assetSystemDbContext = assetSystemDbContext;
            _userManager = userManager;
            _signInManager = signInManager;

        }
      
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
           if (ModelState.IsValid)
            {
                var user = new AccountInfo
                {
                    Email = model.Email,
                    UserName = model.UserNameI,
                    UserNameI = model.UserNameI,
                    PassWordI = Crypto.Encrypt(model.PassWordI)

                };

                var result = await _userManager.CreateAsync(user, model.PassWordI);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("ListUser");
                }
            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async  Task <IActionResult> Login(LoginViewModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //ko đúng ko khóa false
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.PassWordI, model.Remember, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);

                    }
                    else
                    {
                        return RedirectToAction("Index", "Admin");
                    }

                }

                ModelState.AddModelError(string.Empty, "Không hợp lệ");


            }

            return View(model);
        }




        [HttpGet]
        [AllowAnonymous]
        public IActionResult ListUser()
        {
            var query = from u in _assetSystemDbContext.Users
                        from ur in _assetSystemDbContext.UserRoles.DefaultIfEmpty()
                        select new
                        {
                            u.Id,
                            ur.RoleId,
                            u.UserName,
                            u.PassWordI,
                            UserId = ur == null ? null : ur.UserId
                        };
            var query2 = (from x in query
                          from r in _assetSystemDbContext.Roles.DefaultIfEmpty()

                          select new ListUserViewModel
                          {

                              Id = x.Id,
                              UserName = x.UserName,
                              PassWord = x.PassWordI,
                             // RoleName = r == null ? null : r.Name

                          }).ToList();




            return View(query2);

        }

        //edit user get 
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            //check null user            
            var userRoles = await _userManager.GetRolesAsync(user);
            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
               
                Email = user.Email,
                Roles = userRoles
            };
            return View(model);
        }

        //edit user post
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            //check null user
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.ID_UserI = user.ID_UserI;
            //update  có thể kiểm tra trùng tên
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ListUser");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);

            }
            return View(model);

        }






        [HttpGet]
        public IActionResult Decrypt()
        {
            return View();
        }

        [AllowAnonymous]
        public JsonResult Decrypt(string TextEncrypt)
        {
            var text = Crypto.Decrypt(TextEncrypt);

            return Json(text);
        }




    }
}