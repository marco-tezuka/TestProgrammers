using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;
using TesteProgrammers.Repositories;

namespace TesteProgrammers.BO
{
    public class FuncionarioBO : IFuncionarioBO
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioBO(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<List<Funcionario>> Listar()
        {
            return await _funcionarioRepository.Listar();
        }
    }
}
