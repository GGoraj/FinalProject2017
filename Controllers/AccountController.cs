using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dreamstarter_web.Models.ViewModels;
using dreamstarter_web.Models.Entities;
using dreamstarter_web.Models.Repositories;
using dreamstarter_web.Models;
using Microsoft.AspNetCore.Http;

namespace dreamstarter_web.Controllers
{
    public class AccountController : Controller
    {
        /*  temporary solution before I learn proper authorisation
            right now I assume that it would take too much time I dont have
            public static int userId;
         */
        public static int UserId { get; set; }

        private IUserRepository _userRepository;

        //Constructor
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel lvm)
        {

            if (ModelState.IsValid)
            {
                //if ModelState is null - it wont be valid - so no error occures
                bool isValid = _userRepository.ValidateLogin(lvm.Email, lvm.Password);
                if (isValid)
                {
                    UserId = _userRepository.GetIdByEmail(lvm.Email);
                    //HttpContext.Session.SetInt32("UserId", userId);

                    return RedirectToAction("NewCampaign", "Campaign");
                }
            }
            //else
            return View();
        }


        public IActionResult LogOut()
        {
            UserId = 0;
            return RedirectToAction("Index", "Home");
        }




        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignUpViewModel suvm)
        {
            if (ModelState.IsValid)
            {
                User user = new User{
                    Name = suvm.Name,
                    Surname = suvm.Surname,
                    Town = suvm.Town,
                    Postcode = suvm.Postcode,
                    Street = suvm.Street,
                    StreetNr = suvm.StreetNr,
                    Mobile = suvm.Mobile,
                    Email = suvm.Email,
                    Password = suvm.Password
                };
                _userRepository.Save(user);
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View();
            }

        }
    }
}

