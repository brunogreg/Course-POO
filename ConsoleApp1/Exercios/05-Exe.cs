using System.Globalization;
using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe5 {
        public static void Executar() {

            // Estrutura que pega as medidas de um retângulo sendo sua altura e a largura e com isso puxa funções da minha classe Retangulo, calculando sua area seu perimetro e sua diagonal.

            Console.WriteLine("Informe uma medida para ser a largura do retângulo: ");
            Retangulo.Largura = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Informe uma medida para ser a altura do retângulo: ");
            Retangulo.Altura = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Essas são as medidas relacionadas ao retângulo informado: ");
            double areaRetangulo = Retangulo.Area();
            double perimetroRetangulo = Retangulo.Perimetro();
            double diagonalRetangulo = Retangulo.Diagonal();
            Console.WriteLine();
            Console.WriteLine("Área do retângulo = " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro do retângulo = " + perimetroRetangulo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal do retângulo = " + diagonalRetangulo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
