using System.Globalization;

namespace Course.Exercios {
    public class Exe12 {
        public static void Executar() {

            // Cria um vetor onde informa um numero n de alturas que serão informadas e logo apos sera calculada uma media entre elas.

            Console.WriteLine("Informe quantas alturas diferentes você ira digitar");
            int n = int.Parse(Console.ReadLine()!);
            double[] vect = new double[n];

            for (int i = 0; i < n; i++) { // Para captar cada numero informado pelo usuário
                vect[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            double sum = 0.0;  // A cada posição do vetor ele guarda o valor em soma
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("A média das alturas é = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
