using System.Globalization;

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


        public string Nome 
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double Preco
        {
            get { return _preco; }
        }


        public int Quantidade
        {
            get { return _quantidade; }
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
