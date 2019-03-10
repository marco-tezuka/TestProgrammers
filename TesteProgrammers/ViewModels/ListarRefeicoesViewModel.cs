using System.Globalization;
using TesteProgrammers.Models;

namespace TesteProgrammers.ViewModels
{
    public class ListarRefeicoesViewModel
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public string Tamanho { get; set; }
        public string Prato { get; set; }
        public string Composicao { get; set; }
        public string Valor { get; set; }

        public static explicit operator ListarRefeicoesViewModel(Refeicao v)
        {
            return new ListarRefeicoesViewModel
            {
                Id = v.Id,
                Funcionario = v.Funcionario.Nome,
                Prato = v.Composicao.Nome,
                Composicao = v.Composicao.Descricao,
                Tamanho = v.Tamanho.Nome,
                Valor = v.Tamanho.Valor.ToString("C", new CultureInfo("pt-BR"))
            };
        }
    }
}
