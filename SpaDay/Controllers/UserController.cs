using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(User user)
        {
            return View(user);
        }

        // GET: /user/add
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User(addUserViewModel.Username, addUserViewModel.Email, addUserViewModel.Password);
                return View("Index", user);
            }

            return View("Add");

            //if (newUser.Password == verify)
            //{
            //    ViewBag.user = newUser;
            //    return View("Index");
            //}
            //else
            //{
            //    ViewBag.error = "Passwords do not match! Try again!";
            //    ViewBag.userName = newUser.Username;
            //    ViewBag.eMail = newUser.Email;
            //    return View("Add");
            //}
        }

    }
}
