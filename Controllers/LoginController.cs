using lotometroweb.Models;
using LotometroWebAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lotometroweb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            try
            {
                LoginViewModel login = new LoginViewModel();
                return View("Login", login);
            }
            catch(Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
            
        }

    }
}