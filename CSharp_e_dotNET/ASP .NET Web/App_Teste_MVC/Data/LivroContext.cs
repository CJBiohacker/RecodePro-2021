// ARQUIVO CRIADO PELO USUÁRIO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Livros.Models;

namespace App_Teste_MVC.Data
{
    public class LivroContext : DbContext
    {

        public LivroContext(DBContextOptions<LivroContext> opt) : base(opt)
        {

        }

        public DbSet<Livro> Livros { get; set; }        // public DbSet<'nome do tipo criado'> 'nome da tabela' {get; set;}

    }
}