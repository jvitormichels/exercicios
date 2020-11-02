using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace EstoqueSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com as informaçõess abaixo:");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço do produto: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Produto produto1 = new Produto(nome, preco, quantidade);
            Console.WriteLine(produto1);
            Console.WriteLine("\n");

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

        }

    }
}
