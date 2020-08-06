using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repository
{
    public class NewsLetterRepository : INewsLetterRepository
    {
        private LojaVirtualContext _banco;
        public NewsLetterRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodosEmail() //  IEnumerable ou LIST<NewsletterEmail> mesma coisa, porem mais generico
        {
            return _banco.NewsletterEmails.ToList();
        }
    }
}
