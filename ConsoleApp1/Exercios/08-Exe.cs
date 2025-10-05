using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe8 {
        public static void Executar() {

            // Conversor de Dólar para a reais.

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
