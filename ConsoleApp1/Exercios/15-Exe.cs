using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe15 {


        public static void Executar() {

            // Apenas para observar.

            int result = Calculadora.Sum(10, 20, 30, 40); // Chamando o método soma passando pra ele 4 valores de parâmentro.
            Console.WriteLine(result);

            int a = 10;
            Calculadora.Triple(ref a); // Chama a função triple referenciando o valor de a
            Console.WriteLine(a);

            int b = 15; // Chama a função triple referenciando o valor de b
            int triple;
            Calculadora.Triplo(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
