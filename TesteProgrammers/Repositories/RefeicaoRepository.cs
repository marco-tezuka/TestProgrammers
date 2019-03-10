using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteProgrammers.Models;

namespace TesteProgrammers.Repositories
{
    public class RefeicaoRepository : IRefeicaoRepository
    {
        private readonly RestauranteContext _context;

        public RefeicaoRepository(RestauranteContext context)
        {
            _context = context;
        }

        public async Task<List<Refeicao>> Listar(DateTime? dataRefeicao)
        {
            if (!dataRefeicao.HasValue)
                dataRefeicao = DateTime.Today;

            return await _context.Refeicoes
                .Include(r => r.Funcionario)
                .Include(r => r.Composicao)
                .Include(t => t.Tamanho)
                .Where(r => r.DataPedido.Date == dataRefeicao.Value.Date)
                .ToListAsync();
        }

        public async Task<int> Gravar(int funcionarioId, int composicaoId, int tamanhoId)
        {
            var refeicao = new Refeicao();
            refeicao.Funcionario = _context.Funcionarios.Find(funcionarioId);
            refeicao.Composicao = _context.Composicoes.Find(composicaoId);
            refeicao.Tamanho = _context.Tamanhos.Find(tamanhoId);
            refeicao.DataPedido = DateTime.Today;

            _context.Refeicoes.Add(refeicao);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<RefeicaoCliente>> ConsultarRefeicoesClientePorMes(DateTime? dataConsulta)
        {
            var mes = new SqlParameter("@mes", dataConsulta.Value.Month);
            var ano = new SqlParameter("@ano", dataConsulta.Value.Year);

            var sb = new StringBuilder();
            sb.Append("SELECT f.Id FuncionarioId, f.Nome Funcionario, ");
            sb.Append("COUNT(r.Id) QtdRefeicoes, SUM(t.Valor) Total ");
            sb.Append("FROM Refeicao r ");
            sb.Append("INNER JOIN Funcionario f ON r.FuncionarioId = f.Id ");
            sb.Append("INNER JOIN Tamanho t ON r.TamanhoId = t.Id ");
            sb.Append("WHERE MONTH(r.DataPedido) = @mes AND YEAR(r.DataPedido) = @ano ");
            sb.Append("GROUP BY f.Id, f.Nome, r.DataPedido ");
            sb.Append("ORDER BY Total DESC ");

            var consulta = await _context.Query<RefeicaoCliente>()
                .FromSql(sb.ToString(), mes, ano)
                .AsNoTracking()
                .ToListAsync();

            return consulta;
        }
    }
}
