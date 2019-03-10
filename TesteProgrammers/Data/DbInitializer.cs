using System.Linq;
using TesteProgrammers.Models;

namespace TesteProgrammers.Data
{
    public class DbInitializer
    {
        public static void Initialize(RestauranteContext context)
        {
            context.Database.EnsureCreated();

            // Verifica se o banco já foi inicializado
            if (context.Funcionarios.Any())
            {
                return;
            }

            // Popular tabela de funcionários
            var funcionarios = new Funcionario[]
            {
                new Funcionario{Nome="José"},
                new Funcionario{Nome="Antônio"},
                new Funcionario{Nome="Maria"},
                new Funcionario{Nome="Patrícia"},
                new Funcionario{Nome="João"},
                new Funcionario{Nome="Marina"},
                new Funcionario{Nome="Leonardo"},
                new Funcionario{Nome="Juliana"},
                new Funcionario{Nome="Manuel"},
                new Funcionario{Nome="Pedro"}
            };

            foreach (var f in funcionarios)
            {
                context.Funcionarios.Add(f);
            }

            context.SaveChanges();

            var tamanhos = new Tamanho[]
            {
                new Tamanho{Valor=15, Nome="Pequeno"},
                new Tamanho{Valor=20, Nome="Médio"},
                new Tamanho{Valor=25, Nome="Grande"}
            };

            foreach (var t in tamanhos)
            {
                context.Tamanhos.Add(t);
            }

            context.SaveChanges();

            var composicoes = new Composicao[]
            {
                new Composicao{
                    Nome ="Bife Acebolado",
                    Descricao ="Arroz, feijão, salada, batata frita e bife acebolado"
                },
                new Composicao{
                    Nome ="Virado Paulista",
                    Descricao ="Arroz, tutu de feijão, couve, ovo frito, torresmo, banana frita e bisteca de porco"
                },
                new Composicao{
                    Nome ="Feijoada",
                    Descricao ="Feijoada completa, arroz, couve e farofa"
                },
                new Composicao{
                    Nome ="Carne de Panela",
                    Descricao ="Arroz, feijão, salada, batata frita e carne de panela"
                },
                new Composicao{
                    Nome ="Frango a Parmegiana",
                    Descricao ="Arroz, feijão, salada, batata frita e frango a parmegiana"
                }
            };

            foreach (var c in composicoes)
            {
                context.Composicoes.Add(c);
            }

            context.SaveChanges();
        }
    }
}
