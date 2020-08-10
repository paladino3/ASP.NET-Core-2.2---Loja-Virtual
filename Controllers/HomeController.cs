using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Libaries.Email;
using LojaVirtual.Libaries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repository;
using LojaVirtual.Repository.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        private LoginCliente _LoginCliente;
        private IClienteRepository _repositoryCliente;
        private INewsLetterRepository _repositoryNewsLetter;
        public HomeController(IClienteRepository repositoryCliente, INewsLetterRepository repositoryNewsLetter, LoginCliente loginCliente) // injetando meu banco de dados
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsLetter = repositoryNewsLetter;
            _LoginCliente = loginCliente;
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

            Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {

                //Email, Senha, Id, Nome, CPF

                /*
                HttpContext.Session.Set("ID", new byte[] { 52 });
                HttpContext.Session.SetString("Email", cliente.Email); //string
                HttpContext.Session.SetInt32("Idade", 26);  // idade
                */

                _LoginCliente.SalvarCliente(clienteDB);

                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "Usuário ou senha inválidos!<br />Verifique seu dados.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Painel()
        {
            /*  byte[] UsuarioID;
              if (HttpContext.Session.TryGetValue("ID", out UsuarioID))
              {
                  return new ContentResult() { Content = "Usuário " + UsuarioID[0] + " Email: " + HttpContext.Session.GetString("Email") + ", Idade: " + HttpContext.Session.GetInt32("Idade") + ". Logado!" }; // todos esses dodos ficam amarzenados do lado do servidor! ou seja sao criptografados
              }
              else
              {
                  return new ContentResult() { Content = "Acesso negado!" };
              }*/

            Cliente cliente = _LoginCliente.ObterCliente();

            if (cliente != null)
            {
                return new ContentResult() { Content = "Usuário Id: " + cliente.Id + ", E-mail: " + cliente.Email + ", Idade: " + DateTime.Now.AddYears( - cliente.Nascimento.Year).ToString("yy") + " anos." + ", Sexo: " +cliente.Sexo + ", Contato: " + cliente.Telefone + ", CPF: " + cliente.CPF };
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