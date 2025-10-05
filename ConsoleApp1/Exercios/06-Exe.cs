using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe6 {
        public static void Executar() {

            // Estrutura que calcula quanto um funcionário ira receber já descontando o seu imposto e também faz um aumento em porcentagem informado pelo usuário.
            
            Salario x = new();

            Console.Write("Informe o nome do funcionário: ");
            x.Nome = (Console.ReadLine()!);
            Console.Write("Informe o salário bruto de " + x.Nome + ": ");
            x.Valor = double.Parse(Console.ReadLine()!);
            Console.Write("Informe o valor do imposto cobrado: ");
            x.Imposto = double.Parse(Console.ReadLine()!);
            Console.WriteLine(x);
            Console.WriteLine();
            Console.Write("Digite a porcentagem que " + x.Nome + " terá de aumento (sobre seu salário bruto): ");
            int quantidade = int.Parse(Console.ReadLine()!);
            x.AumentarSalario(quantidade);

            Console.WriteLine("Dados atualizados: " + x);
        }
    }
}
