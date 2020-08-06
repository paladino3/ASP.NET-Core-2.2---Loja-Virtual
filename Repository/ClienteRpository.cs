using LojaVirtual.Database;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository
{
    public class ClienteRpository : IClienteRepository
    {
        private LojaVirtualContext _banco;
        public ClienteRpository(LojaVirtualContext banco) //construtor que recebe uma dependencia do banco de dados
        {
            _banco = banco;
        }


        public Cliente Login(string Email, string Senha)
        {
            Cliente cliente = _banco.Clientes.Where(x => x.Email == Email && x.Senha == Senha).First();

            return cliente;
        }

        public void Cadastrar(Cliente cliente)
        {
            _banco.Add(cliente); //ADD Cadastrar
            _banco.SaveChanges();

        }
        public void Remover(int id)
        {
            ObterCliente(id); // usar o metodo obter clientes, primeiro por id dps exclui o cliente
            _banco.Remove(id);
            _banco.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void ObterCliente(int id)
        {
            _banco.Clientes.Find(id);
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _banco.Clientes.ToList();
        }


    }
}
