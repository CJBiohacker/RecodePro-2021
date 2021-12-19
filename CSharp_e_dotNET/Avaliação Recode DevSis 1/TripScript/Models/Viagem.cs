using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TripScript.Models;

namespace TripScript.Models
{
    public class Viagem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Destino { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public int Horario { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }

        public Cliente IdCliente { get; set; }
    }
}