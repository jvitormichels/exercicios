using System;
using System.Collections.Generic;
using _6_Contribuintes.Entities;

namespace _6_Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.Write("Quantidade de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Pessoas física ou jurídica (f/j)? ");
                char pessoaTipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if(pessoaTipo == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosComSaude = double.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numeroDeFuncionarios));
                }
            }

            double impostoTotal = 0.0;
            Console.WriteLine("\nLista de contribuintes:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}\n" +
                    $"Renda anual: R${pessoa.RendaAnual:F2}\n" +
                    $"Imposto: R${pessoa.Imposto():F2}");
                impostoTotal += pessoa.Imposto();
            }

            Console.WriteLine($"\nImposto total arrecadado: R${impostoTotal:F2}");
        }
    }
}
