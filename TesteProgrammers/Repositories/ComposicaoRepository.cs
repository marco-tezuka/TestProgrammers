using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public class ComposicaoRepository : IComposicaoRepository
    {
        private readonly RestauranteContext _context;

        public ComposicaoRepository(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<List<Composicao>> Listar()
        {
            return await _context.Composicoes.ToListAsync();
        }
    }
}
