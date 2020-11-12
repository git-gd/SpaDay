using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.UserName = newUser.UserName;
            ViewBag.Email = newUser.Email;
            ViewBag.Date = newUser.Date;

            return (newUser.Password == verify)? View("Index"): View("Add");
        }
    }
}
