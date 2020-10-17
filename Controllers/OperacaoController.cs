using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock_Sensor.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult EntradaStock()
        {
            return View();
        }
        public ActionResult SaidaStock()
        {
            return View();
        }
        public ActionResult LancPerdas()
        {
            return View();
        }
        public ActionResult Inventarios()
        {
            return View();
        }
    }
}