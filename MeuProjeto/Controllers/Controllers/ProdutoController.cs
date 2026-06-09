using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>()
            {
                "Notebook",
                "Mouse",
                "Teclado",
                "Monitor",
                "Webcam"
            };

            List<double> precos = new List<double>()
            {
                3500,
                50,
                120,
                900,
                80
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}