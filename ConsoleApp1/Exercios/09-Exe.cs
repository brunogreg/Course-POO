using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe9 {
        public static void Executar() {

            // Estrutura de um aplicativo de banco que cria uma conta e realiza operações como depósitos e saques.

            ContaBancaria x;

            Console.Write("Entre com o número da conta: ");
            double numero = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine()!.ToUpper();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine()!.ToUpper();

            if (resposta == "S") {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                x = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                x = new ContaBancaria(numero, titular);  // Construtor que vai jogar um saldo zero na minha conta.
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(x);

            Console.Write("Entre com o valor do depósito inicial: ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.Depositar(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Gostaria de realizar um saque (s/n)? ");
            resposta = Console.ReadLine()!.ToUpper();

            if (resposta == "S") {
                Console.Write("Informe o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine()!);

                x.Sacar(valorSaque);

                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(x);
            }
            else {
                Console.WriteLine("Operação finalizada, obrigado por escolher nosso sistema!");
            }
        }
    }    
}
