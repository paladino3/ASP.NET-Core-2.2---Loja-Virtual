using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Libaries.Email;
using LojaVirtual.Models;
using LojaVirtual.Repository;
using LojaVirtual.Repository.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {

        private IClienteRepository _repositoryCliente;
        private INewsLetterRepository _repositoryNewsLetter;
        public HomeController(IClienteRepository repositoryCliente, INewsLetterRepository repositoryNewsLetter) // injetando meu banco de dados
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsLetter = repositoryNewsLetter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter) //FromForm pega todo o formulario
        {


            if (ModelState.IsValid) // validacao mais simples
            {

                _repositoryNewsLetter.Cadastrar(newsletter);

                TempData["MSG_S"] = "Parabéns e-mail cadastrado com Sucesso! Fique atento as nossas promoções no seu e-mail."; //mostra dados na tela

                return RedirectToAction(nameof(Index)); //retorna o metodo index GET
            }
            else
            {
                return View();
            }

        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao([FromForm]Contato contato)
        {

            try
            {
                //  Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];


                var listaMensagem = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagem, true);

                if (isValid)
                {
                    ContatoEmail.EnviarContaPorEmail(contato); // envia uma mensagem
                    ViewData["MSG_S"] = "Enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var texto in listaMensagem)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }


            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Opps! tivemos um erro, tente novamente mais tarde!" + e;

                // TODO - Implementar log
            }

            return View("Contato");

            //  ContatoEmail.EnviarContaPorEmail(contato);  envia uma mensagem

            //    return new ContentResult() { Content = String.Format("Enviado com Sucesso <br />Nome: {0}  <br /> Email: {1}  <br /> Texto: {2}", contato.Nome, contato.Email, contato.Texto), ContentType = "text/html" };
        }
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastrado realizado com Sucesso!"; //mostra dados na tela

                return RedirectToAction(nameof(CadastroCliente)); //retorna o metodo CadastroCliente GET

            }
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Cliente cliente)
        {
            if (cliente.Email == "rolim.r@hotmail.com" && cliente.Senha == "1234")
            {
                //Email, Senha, Id, Nome, CPF


                HttpContext.Session.Set("ID", new byte[] { 52 });
                HttpContext.Session.SetString("Email", cliente.Email); //string
                HttpContext.Session.SetInt32("Idade", 26);  // idade

                return new ContentResult() { Content = "Logado" };
            }
            else
            {
                return new ContentResult() { Content = "Sem acesso" };
            }
        }

        [HttpGet]
        public IActionResult Painel()
        {
            byte[] UsuarioID;
            if (HttpContext.Session.TryGetValue("ID", out UsuarioID))
            {
                return new ContentResult() { Content = "Usuário " + UsuarioID[0] + ". Logado!" };
            }
            else
            {
                return new ContentResult() { Content = "Acesso negado!" };
            }
        }


        public IActionResult Carrinho()
        {
            return View();
        }
    }
}