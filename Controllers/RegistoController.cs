using Stock_Sensor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock_Sensor.Controllers
{
    public class RegistoController : Controller
    {
        private static List<GrupoProdutoModel> _listaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() {Id=1, Nome="Livros", Ativo=true},
            new GrupoProdutoModel() {Id=2, Nome="canetas", Ativo=true},
            new GrupoProdutoModel() {Id=3, Nome="Copos", Ativo=true}
        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_listaGrupoProduto);
        }
        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult LocalArmazenamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public ActionResult Provincia()
        {
            return View();
        }
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult PerfilUtilizador()
        {
            return View();
        }
        [Authorize]
        public ActionResult Utilizador()
        {
            return View();
        }

    }
}