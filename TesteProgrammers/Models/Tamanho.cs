using System.ComponentModel.DataAnnotations;

namespace TesteProgrammers.Models
{
    public class Tamanho
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        public decimal Valor { get; set; }
    }
}
