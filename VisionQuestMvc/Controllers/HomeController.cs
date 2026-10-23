using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisionQuestMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bienvenido a la Mente de Visiond";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";
            return View();
        }
    }
}