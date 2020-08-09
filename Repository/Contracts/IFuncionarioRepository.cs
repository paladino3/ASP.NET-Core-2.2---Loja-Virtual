using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository.Contracts
{
    public interface IFuncionarioRepository
    {
        void Cadastrar(Funcionario funcionario);
    }
}
