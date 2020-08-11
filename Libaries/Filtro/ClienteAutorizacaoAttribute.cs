using LojaVirtual.Libaries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libaries.Filtro
{
    /*
     *Tipos de filtros:
     * - Autorização => IAuthorizationFilter
     * - Recurso => IResourceFilter
     * - Ação => IActionFilter
     * - Execução => IExceptionFilter
     * - Resultado => IResourceFilter
     */


    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _loginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente)); //casting

            Cliente cliente = _loginCliente.ObterCliente();

            if (cliente == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado!" };
            }

        }
    }
}
