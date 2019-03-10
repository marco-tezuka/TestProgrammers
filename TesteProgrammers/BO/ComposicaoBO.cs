using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;
using TesteProgrammers.Repositories;

namespace TesteProgrammers.BO
{
    public class ComposicaoBO : IComposicaoBO
    {
        private readonly IComposicaoRepository _composicaoRepository;

        public ComposicaoBO(IComposicaoRepository composicaoRepository)
        {
            _composicaoRepository = composicaoRepository;
        }

        public async Task<List<Composicao>> Listar()
        {
            return await _composicaoRepository.Listar();
        }
    }
}
