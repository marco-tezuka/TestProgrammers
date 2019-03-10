using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TesteProgrammers.BO;
using TesteProgrammers.ViewModels;

namespace TesteProgrammers.Controllers
{
    public class RefeicaoController : Controller
    {
        private readonly IRefeicaoBO _refeicaoBO;
        private readonly IFuncionarioBO _funcionarioBO;
        private readonly IComposicaoBO _composicaoBO;
        private readonly ITamanhoBO _tamanhoBO;

        public RefeicaoController(IRefeicaoBO refeicaoBO, IFuncionarioBO funcionarioBO, 
            IComposicaoBO composicaoBO, ITamanhoBO tamanhoBO)
        {
            _refeicaoBO = refeicaoBO;
            _funcionarioBO = funcionarioBO;
            _composicaoBO = composicaoBO;
            _tamanhoBO = tamanhoBO;
        }

        public async Task<IActionResult> Index(DateTime? dataPedido)
        {
            if (!dataPedido.HasValue)
                dataPedido = DateTime.Today;

            ViewData["Data"] = dataPedido.Value.ToString("dd/MM/yyyy");

            return View(await _refeicaoBO.Listar(dataPedido));
        }
       
        public async Task<IActionResult> FazerPedido()
        {
            var funcionarios = await _funcionarioBO.Listar();
            var composicoes = await _composicaoBO.Listar();
            var tamanhos = await _tamanhoBO.Listar();

            var vm = new FazerPedidoViewModel {
                Funcionarios = funcionarios,
                Composicoes = composicoes,
                Tamanhos = tamanhos
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FazerPedido(
            [Bind("FuncionarioId, ComposicaoId, TamanhoId")] FazerPedidoViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _refeicaoBO.Gravar(vm.FuncionarioId, vm.ComposicaoId, vm.TamanhoId);
                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(FazerPedido));
            }
            catch
            {
                return RedirectToAction(nameof(FazerPedido));
            }
        }

        public async Task<IActionResult> ConsultarRefeicoesClientePorMes(DateTime? dataConsulta)
        {
            if (!dataConsulta.HasValue)
                dataConsulta = DateTime.Today;

            ViewData["Mes"] = dataConsulta.Value.ToString("MM/yyyy");

            var consulta = await _refeicaoBO.ConsultarRefeicoesClientePorMes(dataConsulta);
            return View(consulta);
        }
    }
}