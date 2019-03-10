using System.ComponentModel.DataAnnotations;

namespace TesteProgrammers.Models
{
    public class Composicao
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }
    }
}
