using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;
using TesteProgrammers.Repositories;

namespace TesteProgrammers.BO
{
    public class TamanhoBO : ITamanhoBO
    {
        private readonly ITamanhoRepository _tamanhoRepository;

        public TamanhoBO(ITamanhoRepository tamanhoRepository)
        {
            _tamanhoRepository = tamanhoRepository;
        }

        public async Task<List<Tamanho>> Listar()
        {
            return await _tamanhoRepository.Listar();
        }
    }
}
