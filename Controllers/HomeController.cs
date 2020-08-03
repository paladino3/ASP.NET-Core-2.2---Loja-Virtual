using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            string nome = HttpContext.Request.Form["nome"];
            string email = HttpContext.Request.Form["email"];
            string texto = HttpContext.Request.Form["texto"];

            return new ContentResult() { Content = String.Format("Enviado com Sucesso <br />Nome: {0}  <br /> Email: {1}  <br /> Texto: {2}", nome, email, texto), ContentType = "text/html" };
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }
    }
}