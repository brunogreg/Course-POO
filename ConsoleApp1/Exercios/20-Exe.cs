namespace Course.Exercios {
    public class Exe20 {
        public static void Executar() {

            // Estrutura de Expressao condicional ternária.

            Console.WriteLine("Digiete um valor para ver de quanto será o seu desconto");
            double preco = double.Parse(Console.ReadLine()!);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; // Expressao condicional ternária lê se: se preco for menor que 20 então a expressao vai valer 10% se for maior que 20 vai valer 5%
            Console.WriteLine(desconto);       
        }
    }    
}
