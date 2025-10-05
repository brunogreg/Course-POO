using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe13 {
        public static void Executar() {

            // Estrutura de vetor que calcula a média de dos preços dos produtos informados.

            Console.WriteLine("Informe quantos valores serão informado e logo em seguida digite qual os valores: ");
            int n = int.Parse(Console.ReadLine()!);
            Produto2[] vect = new Produto2[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine()!;
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                vect[i] = new Produto2 { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
