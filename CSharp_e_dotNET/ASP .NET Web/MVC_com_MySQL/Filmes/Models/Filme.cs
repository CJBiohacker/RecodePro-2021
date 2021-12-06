using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Referência manual

namespace Filmes.Models
{
    public class Filme
    {
        [Key]           // Define o Atributo Id como PRIMARY KEY da tabela.
        [Required]      // Define o Atributo Id como NOT NULL.
        public int Id { get; set; }
        [Required]      // Define o Atributo Nome como NOT NULL.
        public string Nome { get; set; }
        [Required]      // Define o Atributo Genero como NOT NULL.
        public string Genero { get; set; }
    }
}