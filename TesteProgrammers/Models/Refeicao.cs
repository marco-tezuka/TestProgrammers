using System;
using System.ComponentModel.DataAnnotations;

namespace TesteProgrammers.Models
{
    public class Refeicao
    {
        public Refeicao()
        {
            this.DataPedido = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public Tamanho Tamanho { get; set; }

        [Required]
        public Funcionario Funcionario { get; set; }

        [Required]
        public Composicao Composicao { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }
    }
}
