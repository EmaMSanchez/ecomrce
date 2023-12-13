using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecomerce.Presentacion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Nosotros()
        {
            return View();
        }
        public ActionResult GiftHome()
        {
            return View();
        }
        public ActionResult Giftcard()
        {
            return View();
        }
        
        public ActionResult Ayuda()
        {
            return View();
        }
       
    }
   
}