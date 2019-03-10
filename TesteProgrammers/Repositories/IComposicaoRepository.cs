using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public interface IComposicaoRepository
    {
        Task<List<Composicao>> Listar();
    }
}
