using lotometroweb.Models;
using LotometroWebAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lotometroweb.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Principal()
        {
            try
            {
                PrincipalViewModel principal = new PrincipalViewModel();
                return View("Principal", principal);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }

        }
    }
}