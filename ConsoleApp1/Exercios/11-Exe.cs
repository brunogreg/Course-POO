namespace Course.Exercios {
    public class Exe11 {
        public static void Executar() {

            double? x = null;  // Nullable<double> x = null; é a mesma coisa que "double?" usado para informar que a variavel do tipo valor não tem valor
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor ou o padrão como x = a null (nao tem valor) ele vai pegar o padrao de uma variavel do tipo valor que nao foi definida que é = a zero
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue); // É do tipo bolleano vai informar se tem ou nao valor retornando true ou false
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            /* double? x = null;  Operador de coalescência nula. y vai rece o valor de x se for null ele vai jogar em y o valor 0.0
               double y = x ?? 0.0; */
        }
    }
}
