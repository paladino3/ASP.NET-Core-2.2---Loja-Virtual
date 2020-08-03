using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller //todo controller herda da classe Controller
    {
        /*
         *ActionResult
         *IActionResult
         */
        public ActionResult Visualizar() //na classe controller todo metodo tem que ser ActionResult 
        {
            Produto produto = GetProduto();


            return View(produto);
            //return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" };
        }


        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox One X",
                Descricao = "Jogue em 4k true",
                Valor = 2500.00M
            };
        }
    }
}
