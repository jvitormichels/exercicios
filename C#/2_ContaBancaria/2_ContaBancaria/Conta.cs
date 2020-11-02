using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ContaBancaria
{
    class Conta
    {

        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double Saldo { get; private set; }


        public Conta (int numero, string nome)
        {
            NumeroDaConta = numero;
            NomeDoTitular = nome;
        }

        public Conta (int numero, string nome, double depositoInicial): this(numero, nome)
        {
            Deposito(depositoInicial);
        }


        public void Deposito(double valor)
        {
            Saldo += valor;
        }


        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }


        public override string ToString()
        {
            return $" --- Dados da conta --- \n" +
                $"Número: {NumeroDaConta} \n" +
                $"Nome do titular: {NomeDoTitular} \n" +
                $"Saldo: R${Saldo:F2}";
        }

    }
}
