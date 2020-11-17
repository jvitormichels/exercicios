using System;


namespace _4_ListaDeFuncionarios
{
    class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagemAumento)
        {
            Salario = Salario * ((porcentagemAumento / 100) + 1);
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, R${Salario}";
        }
    }
}
