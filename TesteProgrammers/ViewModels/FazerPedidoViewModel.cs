using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesteProgrammers.Models;

namespace TesteProgrammers.ViewModels
{
    public class FazerPedidoViewModel
    {
        public List<Funcionario> Funcionarios { get; set; }
        public List<Composicao> Composicoes { get; set; }
        public List<Tamanho> Tamanhos { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome.")]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Por favor, informe a composição.")]
        public int ComposicaoId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tamanho.")]
        public int TamanhoId { get; set; }
    }
}
