using System.Globalization;

namespace Course.ClassesAuxiliares {
    internal class Produto { // Nome da classe (toda classe é uma subclasse da classe Object)
        private string _nome;  // Private para deixar o atributo privado e ser acessível apenas por métodos get e set
        private double _preco;  // Se eu optasse por fazer uma auto propertie era so fazer: public double Preco { get; private set; }
        private int _quantidade; // Se eu optasse por fazer uma auto propertie era so fazer: public double Quantidade { get; set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {   // Esse é um exemplo de construtor personalizado que recebe 3 argumentos que permite ou obriga o objeto a receber dados / dependências no momento da sua instanciação
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) {  // Só vai atribuir um novo nome se ele não for nulo e se o tamanho dele for maior que 1.
                    _nome = value;
                }
            }
        }

        public double Preco { // Método properties para obter um preço e não permitir que seja alterado, além de poder usar a variável Preco ao invés de _preco.
            get { return _preco; }
        }

        public int Quantidade { // Método properties para obter a quantidade e não permitir que seja alterada, além de poder usar a variável Quantidade ao invés de _quantidade.
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {  // Void porque não retorna um valor de saída, ela apenas vai mudar o valor da memória do estoque
            _quantidade = _quantidade + quantidade;        // Função para somar mais produtos ao estoque

        }

        public void RemoverProdutos(int quantidade) {    // Void porque não retorna um valor de saída, ela apenas vai mudar o valor da memória do estoque
            _quantidade -= quantidade;                    // Função para subtrair produtos do estoque

        }

        public override string ToString() {             // Essa função define como o produto vai ser transformado na forma string, sendo reaproveitada toda vez que eu precisar
            return "O produto "
                + _nome
                + " de preço unitário de $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", possui "
                + _quantidade
                + " unidades em estoque, com valor total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + " de estoque.";
        }
    }
}
