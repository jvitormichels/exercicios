using System.Globalization;

namespace EstoqueSimples
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }



        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }


        public void AdicionaProduto(int quantidade)
        {
            Quantidade += quantidade;
        }


        public void RemoveProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return $"Dados do produto \n" +
                $"----------------\n" +
                $"Produto: {_nome} \n" +
                $"Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                $"Em estoque: {Quantidade} \n" +
                $"Valor em estoque: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
