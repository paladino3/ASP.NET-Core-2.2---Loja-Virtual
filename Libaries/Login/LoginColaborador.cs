using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libaries.Login
{
    public class LoginColaborador
    {

        private string Key = "Login.Colaborador";
        private Sessao.Sessao _sessao;
        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        public void SalvarColaborador(Colaborador colaborador)
        {
            //Serializar 
            string colaboradorJasonString = JsonConvert.SerializeObject(colaborador); //transforma o objeto cliente em string
            _sessao.Cadastrar(Key, colaboradorJasonString);
        }

        public Colaborador ObterColaborador() //GetColaborador
        {
            //Deserializar
            if (_sessao.Existe(Key))
            {
                string colaboradorJasonString = _sessao.Consultar(Key); // cliente em string
                return JsonConvert.DeserializeObject<Colaborador>(colaboradorJasonString); // string em objeto
            }
            return null;
        }

        public void Logout() // SAIR ou logout
        {
            _sessao.RemoverTodos();
        }

    }
}
