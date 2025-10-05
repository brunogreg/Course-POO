using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe2 {
        public static void Executar() {
            
            // Estrutura de codigo para pegar o nome e a idade de duas pessoas e comparar qual seria a pessoa mais velha. 

            Pessoas x = new (); // Instanciando a classe
            Pessoas y = new ();

            Console.WriteLine("Digite o nome e a idade da primeira pessoa");
            Console.WriteLine("Nome da primeira pessoa:");
            x.Nome = (Console.ReadLine()!);
            Console.WriteLine("Idade da primeira pessoa:");
            x.idade = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o nome e a idade da segunda pessoa");
            Console.WriteLine("Nome da segunda pessoa:");
            y.Nome = (Console.ReadLine()!);
            Console.WriteLine("Idade da segunda pessoa:");
            y.idade = int.Parse(Console.ReadLine()!);

            if (x.idade > y.idade) {
                Console.WriteLine("A pessoa mais velha é: " + x.Nome);
            }
            else {
                Console.WriteLine("A pessoa mais velha é: " + y.Nome);
            }
        }
    }
}
