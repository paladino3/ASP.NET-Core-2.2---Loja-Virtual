using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libaries.Sessao
{
    public class Sessao
    {
        /*CRUD sao operacoes basicas de todos os sistemas
         * 
         *C =>CREATE / R => READ / U => UPDATE / D => DELETE
         * 
         * CADASTRAR / CONSULTAR / ATUALIZAR / REMOVER
         */

        private IHttpContextAccessor _context;
        public Sessao(IHttpContextAccessor context)
        {
            _context = context;  // injecao de dependencia da sessao
        }

        public void Cadastrar(string key, string valor)
        {
            _context.HttpContext.Session.SetString(key, valor);

        }

        public void Atualizar(string key, string valor)
        {
            if (Existe(key))
            {
                _context.HttpContext.Session.Remove(key);
            }

            _context.HttpContext.Session.SetString(key, valor);
        }

        public void Remover(string key)
        {
            _context.HttpContext.Session.Remove(key);
        }

        public string Consultar(string key)
        {
           return _context.HttpContext.Session.GetString(key);
        }

        public bool Existe(string key)
        {
            if (_context.HttpContext.Session.GetString(key) == null)
            {
                return false;
            }
            return true;
        }

        public void RemoverTodos()
        {
            _context.HttpContext.Session.Clear();
        }
    }
}
