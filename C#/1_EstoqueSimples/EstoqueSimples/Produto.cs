using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EstoqueSimples
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionaProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto \n" +
                $"----------------\n" +
                $"Produto: {_nome} \n" +
                $"Preço: R${_preco.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                $"Em estoque: {_quantidade} \n" +
                $"Valor em estoque: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
