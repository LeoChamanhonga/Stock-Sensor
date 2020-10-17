using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock_Sensor.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult EstadoStock()
        {
            return View();
        }
        [Authorize]
        public ActionResult Encomenda()
        {
            return View();
        }

    }
}