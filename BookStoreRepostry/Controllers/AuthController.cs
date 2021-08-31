using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreRepostry.Models;
using BookStoreRepostry.Models.Repositores;
using BookStoreRepostry.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreRepostry.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AuthController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
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
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                       
                        foreach ( var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);

                        }
                        return View();

                    }
                 
                    //                    registerViewModel.add(author);

                    //  return RedirectToAction(nameof(Details), new { id = author.Id });
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
        


        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    // TODO: Add insert logic here

                    var user = new IdentityUser() { Email = loginViewModel.Email };
                    var result = await userManager.CreateAsync(user, loginViewModel.Password);

                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {

                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);

                        }
                        return View();

                    }
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
    }
}