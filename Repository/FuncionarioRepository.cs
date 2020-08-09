using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private LojaVirtualContext _banco;
        public FuncionarioRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Funcionario funcionario)
        {
            _banco.Add(funcionario);
            _banco.SaveChanges();

        }
    }
}
