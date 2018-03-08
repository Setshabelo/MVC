using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class RegisterController : Controller
    {
        AllContext context = new AllContext();
        // GET: Register
        public ActionResult Registering()
        {
          return View();
        }
           

        [HttpPost]
        public ActionResult Registering(Register register)
        {
            if (ModelState.IsValid)
            {
                context.Entry(register).State = System.Data.Entity.EntityState.Added;
                context.SaveChangesAsync();
                RedirectToAction("Index", "Home");

            }
            else
            {
                return View("Registering",register);
            }
            return RedirectToAction("Login","Login");
        }
    }
}