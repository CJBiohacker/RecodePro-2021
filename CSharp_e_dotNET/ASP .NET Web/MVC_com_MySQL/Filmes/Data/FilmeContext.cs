using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Referência manual
using Microsoft.Extensions.Options; // Referência manual
using Filmes.Models; // Referência manual

namespace Filmes.Data
{
    public class FilmeContext : DbContext
    {
        // Construtor de Classe do Banco de Dados   
        public FilmeContext(DbContextOptions<FilmeContext> Options) : base(Options)
        {

        }

        public DbSet<Filme> Filmes { get; set; }    // Utilizando a Classe Filme como tipo de dados para configuração da tabela/atributo Filmes do Banco de Dados
    }
}