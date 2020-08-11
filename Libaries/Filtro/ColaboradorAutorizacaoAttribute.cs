using LojaVirtual.Libaries.Login;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc.Filters;
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

    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginColaborador _loginColaborador;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador)); //casting

            Models.Colaborador colaborador = _loginColaborador.ObterColaborador();

            if (colaborador == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado!" };
            }

        }
    }
}
