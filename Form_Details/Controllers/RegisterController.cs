using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Form_Details.Models;


namespace Form_Details.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Register(RegisterModel register)
        {
            return View();
        }
    }
}