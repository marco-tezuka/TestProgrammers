using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly RestauranteContext _context;

        public FuncionarioRepository(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<List<Funcionario>> Listar()
        {
            return await _context.Funcionarios.ToListAsync();
        }
    }
}
