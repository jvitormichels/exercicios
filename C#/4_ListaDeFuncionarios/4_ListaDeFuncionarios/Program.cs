using System;
using System.Collections.Generic;

namespace _4_ListaDeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            char escolha;
            do
            {
                Console.WriteLine("O que deseja fazer? \n1.Adicionar um novo funcionário \n2.Aumentar o salário de um funcionário \n3.Listar os funcionários \n4.Sair");
                escolha = char.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolha)
                {
                    case '1':
                        Console.WriteLine($"Informe os dados do funcionário: ");
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Salário: ");
                        double salario = double.Parse(Console.ReadLine());
                        Console.Clear();
                        funcionarios.Add(new Funcionarios(id, nome, salario));
                        break;

                    case '2':
                        Console.Write("Informe o ID do funcionário: ");
                        int idPesquisado = int.Parse(Console.ReadLine());
                        Funcionarios aux = funcionarios.Find(x => x.Id == idPesquisado);
                        if (aux == null)
                        {
                            Console.WriteLine("Id inválido!");
                        }
                        else
                        {
                            Console.Write("Informe a porcentagem: ");
                            double porcentagem = double.Parse(Console.ReadLine());
                            aux.AumentoSalario(porcentagem);
                        }
                        break;

                    case '3':
                        foreach (Funcionarios obj in funcionarios)
                        {
                            Console.WriteLine(obj);
                        }

                        Console.WriteLine("\n");
                        Console.Write("Insira qualquer coisa para continuar");
                        char pauseControl = char.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                }
            } while (escolha != '4');
        }
    }
}
