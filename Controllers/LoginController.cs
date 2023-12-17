using mvc.Models;
using mvc.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");

        } 

        public string Login(userModel userModel)
        {
            /*return "username: " + userModel.UserName + " password: " + userModel.Password;*/
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(userModel);

            if (success) { return "Win"; }
            else { return "lose"; }
        }
        
    }
}