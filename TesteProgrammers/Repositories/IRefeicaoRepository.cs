using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public interface IRefeicaoRepository
    {
        Task<List<Refeicao>> Listar(DateTime? dataRefeicao);
        Task<int> Gravar(int funcionarioId, int composicaoId, int tamanhoId);
        Task<List<RefeicaoCliente>> ConsultarRefeicoesClientePorMes(DateTime? dataConsulta);
    }
}
