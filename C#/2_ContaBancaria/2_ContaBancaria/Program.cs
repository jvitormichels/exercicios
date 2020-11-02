using System;

namespace _2_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta contaBanco;

            Console.Write("Informe o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            string nomeDoTitular = Console.ReadLine();

                      
            Console.Write("Deseja fazer um dépósito inicial? (s/n) ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 's')
            {
                Console.Write("Informe o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                contaBanco = new Conta(numeroDaConta, nomeDoTitular, depositoInicial);
            }
            else
            {
                contaBanco = new Conta(numeroDaConta, nomeDoTitular);
            }
            

            //Conta contaBanco = new Conta(numeroDaConta, nomeDoTitular);

            Console.WriteLine();
            Console.WriteLine($"\n{contaBanco}");

            Console.WriteLine();
            Console.Write("Informe o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            contaBanco.Deposito(deposito);

            Console.WriteLine($"\n{contaBanco}");

            Console.WriteLine();
            Console.Write("Informe o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
            contaBanco.Saque(saque);

            Console.WriteLine($"\n{contaBanco}");



        }
    }
}
