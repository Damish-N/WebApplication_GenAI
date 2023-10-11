using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.Entity;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext dbContext;
        public AccountController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.User model)
        {
            if (ModelState.IsValid)
            {
                dbContext.Users.Add(model);
                dbContext.SaveChanges();
                // Save the user to your database or perform registration logic here
                // For simplicity, we'll just return a success message in this example
                return Content("Registration successful!");
            }

            // If registration fails, return to the registration form with validation errors
            return View(model);
        }
    }
}