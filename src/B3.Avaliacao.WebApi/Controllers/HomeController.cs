using B3.Avaliacao.WebApi.Application;
using B3.Avaliacao.WebApi.Models;
using Microsoft.AspNetCore.Cors;
using System.Web.Http;
using System.Web.Mvc;

namespace B3.Avaliacao.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
