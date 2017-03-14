using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositoriorio;

        public ActionResult Index()
        {
            _repositoriorio = new ProdutosRepositorio();
            var produtos = _repositoriorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}