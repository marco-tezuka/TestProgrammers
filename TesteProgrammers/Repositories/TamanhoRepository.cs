using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public class TamanhoRepository : ITamanhoRepository
    {
        private readonly RestauranteContext _context;

        public TamanhoRepository(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<List<Tamanho>> Listar()
        {
            return await _context.Tamanhos.ToListAsync();
        }
    }
}
