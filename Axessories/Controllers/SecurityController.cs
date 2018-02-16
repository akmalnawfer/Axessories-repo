using Axessories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Axessories.Controllers
{
    public class SecurityController : Controller
    {
        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            var viewModel = new LoginViewModel();
            ViewBag.returnURL = ReturnUrl;
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel, string ReturnUrl)
        {
            return Content("Logged");
        }
    }
}