using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libaries.Login
{

    /*
     *FOI BAIXADO O PACOTE NUGET (NEWTONSOFT.JASON) 
     */


    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void SalvarCliente(Cliente cliente)
        {
            //Serializar 
            string clienteJasonString = JsonConvert.SerializeObject(cliente); //transforma o objeto cliente em string
            _sessao.Cadastrar(Key, clienteJasonString);
        }

        public Cliente ObterCliente() //GetClient
        {
            //Deserializar
            if (_sessao.Existe(Key))
            {
                string clienteJasonString = _sessao.Consultar(Key); // cliente em string
                return JsonConvert.DeserializeObject<Cliente>(clienteJasonString); // string em objeto
            }
            return null;
        }

        public void Logout() // SAIR ou logout
        {
            _sessao.RemoverTodos();
        }

    }
}
