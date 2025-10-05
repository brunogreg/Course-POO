using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe1 {
        public static void Executar() {       
            
            // Estrutura para pegar a medida de dois triangulos e comparar qual tem a area maior puxando o metódo dentro da minha classe Triangulo.

            Triangulo x = new(); // Instanciando a Classe
            Triangulo y = new();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double areaX = x.Area();  // Chamando o método que está dentro da Class Triangulo
            double areaY = y.Area();

            Console.WriteLine("Área do triângulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
