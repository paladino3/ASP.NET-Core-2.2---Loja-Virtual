
using LojaVirtual.Models;
using LojaVirtual.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class AdmController : Controller // toda controller herda da classe controller
    {


        private IFuncionarioRepository _funcionarioRepository;
        public AdmController(IFuncionarioRepository funcionarioRepository) // injetando meu banco de dados
        {
            _funcionarioRepository = funcionarioRepository;
        }



        [HttpGet]
        public IActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Inicio([FromForm] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRepository.Cadastrar(funcionario);

                TempData["MSG_S"] = "Cadastro realizado com Sucesso!"; //mostra dados na tela

                return RedirectToAction(nameof(Inicio)); //retorna o metodo index GET
            }
            TempData["MSG_E"] = "Erro, volte mais tarde!"; //mostra dados na tela
            return View();
        }


    }
}