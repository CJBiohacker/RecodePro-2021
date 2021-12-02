// ARQUIVO CRIADO PELO USUÁRIO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App_Teste_MVC.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}