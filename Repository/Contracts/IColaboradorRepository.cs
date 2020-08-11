using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository.Contracts
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);

        //CRUD
        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void Remover(int id);
        void ObterColaborador(int id);
        IEnumerable<Colaborador> ObterTodosColaboradores();

    }
}
