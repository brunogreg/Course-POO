using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe3 {
        public static void Executar() {     
            
            // Estrutura para pegar dois funcionarios e fazer a media de seus salarios entre eles.

            Salario x = new();
            Salario y = new();

            double soma;

            Console.WriteLine("Digite o nome e salário do primeiro funcionário");
            Console.WriteLine("Nome do primeiro funcionário:");
            x.Nome = Console.ReadLine()!;
            Console.WriteLine("Digite o salário do primeiro funcionário (separe o valor com vírgula): ");
            x.Valor = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nome do segundo funcionário:");
            y.Nome = Console.ReadLine()!;
            Console.WriteLine("Digite o salário do segundo funcionário (separe o valor com vírgula): ");
            y.Valor = double.Parse(Console.ReadLine()!);

            soma = (x.Valor + y.Valor) / 2.00;
            Console.WriteLine("A média dos salários desses dois funcionários é: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    
}
