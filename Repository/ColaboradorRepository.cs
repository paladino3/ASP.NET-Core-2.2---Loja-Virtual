using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository
{
    public class ColaboradorRepository : IColaboradorRepository
    {

        private LojaVirtualContext _banco;
        public ColaboradorRepository(LojaVirtualContext banco) //construtor que recebe uma dependencia do banco de dados
        {
            _banco = banco;
        }

        public Colaborador Login(string Email, string Senha)
        {
            Colaborador colaborador = _banco.Colaboradores.Where(x => x.Email == Email && x.Senha == Senha).FirstOrDefault();

            return colaborador;
        }

        public void Cadastrar(Colaborador colaborador)
        {
            _banco.Add(colaborador); //ADD Cadastrar
            _banco.SaveChanges();
        }

        public void Remover(int id)
        {
            ObterColaborador(id); // usar o metodo obter colaborador, primeiro por id dps exclui o colaborador
            _banco.Remove(id);
            _banco.SaveChanges();
        }

        public void Atualizar(Colaborador colaborador)
        {
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }


        public void ObterColaborador(int id)
        {
            _banco.Colaboradores.Find(id);
        }

        public IEnumerable<Colaborador> ObterTodosColaboradores()
        {
            return _banco.Colaboradores.ToList();
        }


    }
}
