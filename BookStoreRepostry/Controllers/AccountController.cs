using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreRepostry.Models;
using BookStoreRepostry.Models.Repositores;
using BookStoreRepostry.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreRepostry.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckRegister(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    // TODO: Add insert logic here

                    var user = new IdentityUser() { Email = registerViewModel.Email, UserName = registerViewModel.UserName };
                    var result=await  userManager.CreateAsync(user, registerViewModel.Password);

                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Dashboard");

                    }
                    else
                    {
                       
                        foreach ( var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);

                        }
                        return View("Register");

                    }
                 
                    //                    registerViewModel.add(author);

                    //  return RedirectToAction(nameof(Details), new { id = author.Id });
                }
                catch
                {
                    return View("Register");
                }
            }
            return View("Register");
        }
        


        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {

                // TODO: Add insert logic here

                    var result = await signInManager.PasswordSignInAsync(loginViewModel.UserName, 
                        loginViewModel.Password,loginViewModel.RememberMy,false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                            ModelState.AddModelError("","invaid Login Attempt");       
                    

                    }
                }

        
            return View(loginViewModel);
        }
        public async Task<IActionResult> LogOut()
        {
         
             
           await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");


        }
    }
}