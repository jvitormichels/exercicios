using System;

namespace ConversorDeNumerosEntreBases
{
    class Program
    {
        static void Main(string[] args)
        {

            char rep;

            do
            {
                Console.WriteLine("--- Conversor de números entre bases ---");
                Console.Write("Informe um valor em base 10: ");
                int valorBaseDez = int.Parse(Console.ReadLine());
                Console.Write("Informe a base para a qual deseja converter: ");
                int novaBase = int.Parse(Console.ReadLine());

                {
                    string valorConvertido = "";
                    int quociente;
                    int resto;

                    do
                    {
                        quociente = valorBaseDez / novaBase;
                        resto = valorBaseDez % novaBase;
                        valorConvertido = resto.ToString() + valorConvertido.ToString();
                        valorBaseDez = quociente;

                    } while (quociente != 0);

                    Console.WriteLine(valorConvertido);

                }

                Console.WriteLine("\n");
                Console.WriteLine("Deseja calcular novamente? (s/n)");
                rep = char.Parse(Console.ReadLine());

            } while (rep != 'n');

        }
    }
}
