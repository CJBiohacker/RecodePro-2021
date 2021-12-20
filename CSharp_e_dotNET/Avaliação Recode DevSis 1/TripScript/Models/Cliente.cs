﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TripScript.Models
{
    public partial class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNasc { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Celular { get; set; }

    }
}
