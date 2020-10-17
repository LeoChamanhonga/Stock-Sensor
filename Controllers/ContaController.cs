using Stock_Sensor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Stock_Sensor.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);

            }
            var achou = (login.Utilizador == "nuno" && login.Senha == "123");

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.Utilizador, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }

            }
            else
            {
                ModelState.AddModelError("", "Login Invalido.");
            }
            return View(login);
        }
    }
}