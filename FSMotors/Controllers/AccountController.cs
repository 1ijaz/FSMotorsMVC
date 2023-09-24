using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSMotors.Controllers
{
    public class AccountController : Controller
    {
        //login method
        public IActionResult Login()
        {
            return View();
        }
        //Register method
        public IActionResult Register()
        {
            return View();
        }
    }
}
