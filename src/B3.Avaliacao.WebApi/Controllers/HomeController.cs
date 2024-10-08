using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B3.Avaliacao.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Omitindo o tratamento de exceções propositalmente
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
