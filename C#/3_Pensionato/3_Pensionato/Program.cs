using System;

namespace _3_Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];
            Console.WriteLine("Quantos quartos serão alugados?");
            int quartosAlugados = int.Parse(Console.ReadLine());

            for (int i = 0; i < quartosAlugados; i++)
            {
                Console.Write("Informe o número do quarto: ");
                int nQuarto = int.Parse(Console.ReadLine());
                Console.Write("Informe seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe seu email: ");
                string email = Console.ReadLine();

                quartos[nQuarto] = new Quarto(nome, email, nQuarto);
            }


            Console.WriteLine(" --- Relatório de quartos ---\n");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
