using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteProgrammers.Models;
using TesteProgrammers.Repositories;
using TesteProgrammers.ViewModels;

namespace TesteProgrammers.BO
{
    public class RefeicaoBO : IRefeicaoBO
    {
        private readonly IRefeicaoRepository _refeicaoRepository;

        public RefeicaoBO(IRefeicaoRepository refeicaoRepository)
        {
            _refeicaoRepository = refeicaoRepository;
        }

        public async Task<List<ListarRefeicoesViewModel>> Listar(DateTime? dataRefeicao)
        {
            var refeicoes = await _refeicaoRepository.Listar(dataRefeicao);

            return refeicoes.Select(r => (ListarRefeicoesViewModel) r).ToList();
        }

        public async Task<int> Gravar(int funcionarioId, int composicaoId, int tamanhoId)
        {
            return await _refeicaoRepository.Gravar(funcionarioId, composicaoId, tamanhoId);
        }

        public async Task<List<RefeicaoCliente>> ConsultarRefeicoesClientePorMes(DateTime? dataConsulta)
        {
            return await _refeicaoRepository.ConsultarRefeicoesClientePorMes(dataConsulta);
        }
    }
}
