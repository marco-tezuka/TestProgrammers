using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;
using TesteProgrammers.ViewModels;

namespace TesteProgrammers.BO
{
    public interface IRefeicaoBO
    {
        Task<List<ListarRefeicoesViewModel>> Listar(DateTime? dataRefeicao);
        Task<int> Gravar(int funcionarioId, int composicaoId, int tamanhoId);
        Task<List<RefeicaoCliente>> ConsultarRefeicoesClientePorMes(DateTime? dataConsulta);
    }
}
