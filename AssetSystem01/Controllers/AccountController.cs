using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetSystem01.Models;
using AssetSystem01.Data;
using AssetSystem01.Common;
using AssetSystem01.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AssetSystem01.Controllers
{
    public class AccountController : Controller
    {
        private readonly AssetSystemDbContext _assetSystemDbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(AssetSystemDbContext assetSystemDbContext 
            , UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _assetSystemDbContext = assetSystemDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var obj = new User();
                obj.Name2 = model.UserName2;
                obj.UserName2 = model.UserName2;
                obj.UserName = model.UserName2;
                obj.NormalizedUserName = model.UserName2;
                obj.PassWord2 = Crypto.Encrypt(model.Password);
                _assetSystemDbContext.Add(obj);
                _assetSystemDbContext.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View("Register", new RegisterViewModel());
            }
            
        }
        //login

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model,string returnUrl=null)
        {
            if(ModelState.IsValid)
            {
                //var result = await _signInManager.PasswordSignInAsync(model.UserName2, model.Password, model.Remember, false);
                var result = _assetSystemDbContext.Users.Where(m=>m.UserName2==model.UserName2 && m.PassWord2 == Crypto.Encrypt(model.Password)).FirstOrDefault();
                if (result !=null) //có dữ liệu
                {
                   
                    
                        return RedirectToAction("Index", "Admin");
                    
                    

                }
                else
                {
                    return View("Login", new LoginViewModel());
                }



            }
            return View("Login", new LoginViewModel());
        }


    }
}
