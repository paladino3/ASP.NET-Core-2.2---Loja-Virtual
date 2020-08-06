using LojaVirtual.Migrations;
using LojaVirtual.Models;
using System.Collections.Generic;
using NewsletterEmail = LojaVirtual.Models.NewsletterEmail;

namespace LojaVirtual.Repository.Contracts
{
    public interface INewsLetterRepository
    {

        void Cadastrar(NewsletterEmail newsletter);

        IEnumerable<NewsletterEmail> ObterTodosEmail();

    }
}
