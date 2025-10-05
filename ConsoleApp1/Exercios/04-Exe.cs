using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe4 {
        public static void Executar() {

            // Estrutura que voce informa um produto seu preço e a quantidade que tem no estoque, logo em seguida é possivel fazer alterações no estoque dando entrada e saida desse produto.

            Console.WriteLine("Informe por gentileza os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Produto p = new(nome, preco, quantidade); // No local de quantidade também posso setar o valor que quero iniciar.            

            Console.WriteLine();
            Console.WriteLine("Dados do estoque: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade do produto " + p.Nome + " que será adicionada ao estoque atual: ");   // GetNome para chamar um atributo privativo
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite a quantidade do produto " + p.Nome + " que será removida do estoque atual: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
    
}
