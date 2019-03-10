using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.BO
{
    public interface ITamanhoBO
    {
        Task<List<Tamanho>> Listar();
    }
}
