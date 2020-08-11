using LojaVirtual.Libaries.Filtro;
using LojaVirtual.Libaries.Login;
using LojaVirtual.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")] // essa anotaion é obrigatoria!!!
    public class HomeController : Controller
    {
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _loginColaborador;
        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador loginColaborador)
        {
            _repositoryColaborador = repositoryColaborador;
            _loginColaborador = loginColaborador;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {
                _loginColaborador.SalvarColaborador(colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "Usuário ou senha inválidos!<br />Verifique seu dados.";
                return View();
            }
        }

        [ColaboradorAutorizacao]
        public IActionResult Logout()
        {
          _loginColaborador.Logout();
            return RedirectToAction("Login", "Home", new { area = ""});
        }


        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {
            return View();
        }
    }
}