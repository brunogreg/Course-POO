namespace Course.ClassesAuxiliares {
    internal class Calculadora {
        public static int Sum(params int[] numbers) { // Para definir uma função com parametros variaveis mantendo o vetor e adicionando params que avisa ao compilador que pode receber uma quantidade variavel de parametros no meu vetor

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        } // A seguir temos um exemplo de " code smells" (design ruim) que deve ser evitado!
        public static void Triple(ref int x) { // Precisa que a variavel seja iniciada com algum valor
            x = x * 3;
        }
        public static void Triplo(int origin, out int result) { // A função recebe uma variavel origin que tem um parametro de saida
            result = origin * 3;
        }
    }
}
