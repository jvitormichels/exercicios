using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace EstoqueSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o número de produtos que deseja inserir: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Produto[] listaDeProdutos = new Produto[quantidadeProdutos];


            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($" --- Produto n°{i+1} ---");
                Console.WriteLine("Entre com as informaçõess abaixo:");
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto: R$");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                listaDeProdutos[i] = new Produto(nome, preco, quantidade);
                Console.WriteLine();
            }

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(listaDeProdutos[i]);
            }

            double soma = 0;
            for (int i = 0; i < quantidadeProdutos; i++)
            {
                soma += listaDeProdutos[i].ValorTotalEmEstoque();
            }
            double media = soma / quantidadeProdutos;

            Console.WriteLine("\n----------\n");
            Console.WriteLine("Preço médio: " + media.ToString("F2"));
            /*
            Console.Write("Informe a quantidade a ser adicionada ao estoque: ");
            produto1.AdicionaProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine(produto1);
            Console.WriteLine("\n");

            Console.Write("Informe a quantidade a ser removida do estoque: ");
            produto1.RemoveProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine(produto1);
            Console.WriteLine("\n");
            */
        }

    }
}
