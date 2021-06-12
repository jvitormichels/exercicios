using System;
using System.Collections.Generic;

namespace EstoqueSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            bool sair = false;


            //Alimentando a lista
            {
                nomes.Add("João Pessoa");
                nomes.Add("Maju");
                nomes.Add("Jhey");
                nomes.Add("Michels");
                nomes.Add("Gabs");
                nomes.Add("Kitsel");
                nomes.Add("Naielli");
                nomes.Add("Tiago");
                nomes.Add("Carolina");
                nomes.Add("Daniel");
                nomes.Add("Erik");
                nomes.Add("Nalara");
                nomes.Add("Gabriel");
                nomes.Add("Louis");
                nomes.Add("Pedro 1");
                nomes.Add("Pedro 2");
                nomes.Add("Kaue");
                nomes.Add("Luan");
                nomes.Add("Beatriz");
                nomes.Add("Michel");
                nomes.Add("Jerod");
                nomes.Add("Casaco");
                nomes.Add("Adriano");
            }


            do
            {
                Console.WriteLine();
                System.Console.WriteLine(" --- Inserção de dados em uma lista de strings ---\n");
                System.Console.WriteLine("1.Inserir ao fim da lista \n" +
                    "2.Inserir em uma posição específica \n3.Mostrar lista \n" +
                    "4.Procurar o primeiro nome que comece com certa letra \n" +
                    "5.Procurar o último nome que comece com certa letra \n" +
                    "6.Filtrar nomes que comecem com certa letra \n" +
                    "7.Remover nomes que comecem com certa letra \n" +
                    "8.Remover nome por posição \n" +
                    "9.Remover n nomes a partir de uma posição \n" +
                    "10.Sair \n");
                int escolha = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();


                string pause;

                switch (escolha)
                {
                    case 1:
                        Console.Write("Informe o nome: ");
                        string newNome = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newNome)) 
                        {
                            nomes.Add(newNome);
                        }
                        Console.Clear();
                        break;


                    case 2:
                        Console.Write("Informe a posição: ");
                        int position = (int.Parse(Console.ReadLine())) - 1;
                        Console.Write("Informe o nome: ");
                        newNome = Console.ReadLine();

                        if (position > nomes.Count + 1 || position < 0) {
                            Console.WriteLine("Posição inválida! \nO nome será adicionado ao fim da lista!");
                            nomes.Add(newNome);
                            Console.WriteLine("----\n");
                            Console.Write("Pressione Enter para continuar");
                            pause = Console.ReadLine();
                            Console.Clear();
                        }

                        if (!string.IsNullOrEmpty(newNome)) 
                        {
                            if (position > nomes.Count + 1 || position < 0) 
                            {
                                Console.WriteLine("Posição inválida! \nO nome será adicionado ao fim da lista!");
                                nomes.Add(newNome);
                            }
                            else 
                            {
                                nomes.Insert(position, newNome);
                            }
                        }

                        Console.Clear();
                        break;


                    case 3:
                        Console.WriteLine("\n --- Lista de nomes ---");
                        Console.WriteLine($"Número de elementos: {nomes.Count}");
                        foreach (string obj in nomes)
                        {
                            Console.WriteLine($"P{nomes.FindIndex(x => x == obj)}°: {obj}");
                        }
                        Console.WriteLine("----\n");
                        Console.Write("Pressione Enter para continuar");
                        pause = Console.ReadLine();
                        Console.Clear();
                        break;


                    case 4:
                        Console.Write("Informe a letra com a qual o nome deve começar: ");
                        char letraPesquisar = char.Parse(Console.ReadLine());
                        string nomePesquisado = nomes.Find(x => x[0] == letraPesquisar);

                        if (!string.IsNullOrEmpty(nomePesquisado)) 
                        {
                            Console.WriteLine($"\nPrimeiro nome que começa com {letraPesquisar} ---");
                            Console.WriteLine($"Resultado: P{nomes.FindIndex(x => x[0] == letraPesquisar)}) {nomePesquisado}");
                            Console.WriteLine("----\n");
                            Console.Write("Pressione Enter para continuar");
                            pause = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Não encontrado!");
                            Console.WriteLine("----\n");
                            Console.Write("Pressione Enter para continuar");
                            pause = Console.ReadLine();
                            Console.Clear();
                        }

                        break;


                    case 5:
                        Console.Write("Informe a letra com a qual o nome deve começar: ");
                        letraPesquisar = char.Parse(Console.ReadLine());
                        nomePesquisado = nomes.FindLast(x => x[0] == letraPesquisar);

                        if (!string.IsNullOrEmpty(nomePesquisado))
                        {
                            Console.WriteLine($"\nÚltimo nome que começa com {letraPesquisar} ---");
                            Console.WriteLine($"Resultado: P{nomes.FindLastIndex(x => x[0] == letraPesquisar)}) {nomePesquisado}");
                            Console.WriteLine("----\n");
                            Console.Write("Pressione Enter para continuar");
                            pause = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Não encontrado!");
                            Console.WriteLine("----\n");
                            Console.Write("Pressione Enter para continuar");
                            pause = Console.ReadLine();
                            Console.Clear();
                        }

                        break;


                    case 6:
                        Console.Write("Informe a letra com a qual o nome deve começar: ");
                        letraPesquisar = char.Parse(Console.ReadLine());
                        List<string> filtro = nomes.FindAll(x => x[0] == letraPesquisar);

                        Console.WriteLine($"\nNomes que começam com {letraPesquisar}:");
                        foreach (string obj in filtro)
                        {
                            Console.WriteLine($"P{nomes.FindIndex(x => x == obj)}°: {obj}");
                        }

                        Console.WriteLine("----\n");
                        Console.Write("Pressione Enter para continuar");
                        pause = Console.ReadLine();
                        Console.Clear();

                        break;


                    case 7:
                        Console.Write("Informe a letra com a qual o nome deve começar: ");
                        letraPesquisar = char.Parse(Console.ReadLine());
                        nomes.RemoveAll(x => x[0] == letraPesquisar);
                        break;


                    case 8:
                        Console.Write("Informe a posição a ser removida: ");
                        int posicao = int.Parse(Console.ReadLine());
                        nomes.RemoveAt(posicao);
                        break;


                    case 9:
                        Console.Write("Informe a posição a ser de início: ");
                        int posicaoInicio = int.Parse(Console.ReadLine());
                        Console.Write("Informe o número de posições: ");
                        int alcance = int.Parse(Console.ReadLine());
                        nomes.RemoveRange(posicaoInicio, alcance);
                        break;


                    case 10:
                        sair = true;
                        break;

                }

            } while (sair == false);

        }

    }
}
