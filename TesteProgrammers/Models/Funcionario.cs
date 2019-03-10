﻿using System.ComponentModel.DataAnnotations;

namespace TesteProgrammers.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
