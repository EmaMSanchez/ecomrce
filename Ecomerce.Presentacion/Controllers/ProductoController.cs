using Ecomerce.Dominioo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecomerce.Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Nuevo(ProductoDTO producto)
        {
            return View();
        }
    }
}