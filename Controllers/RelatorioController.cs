using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock_Sensor.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult EstadoStock()
        {
            return View();
        }
        public ActionResult Encomenda()
        {
            return View();
        }

    }
}