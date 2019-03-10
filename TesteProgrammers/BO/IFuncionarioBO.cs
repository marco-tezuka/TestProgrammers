using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.BO
{
    public interface IFuncionarioBO
    {
        Task<List<Funcionario>> Listar();
    }
}
