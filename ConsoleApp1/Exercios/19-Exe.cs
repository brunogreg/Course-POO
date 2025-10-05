namespace Course.Exercios {
    public class Exe19 {

        // Estrutura de Matrizes para informar a diagonal principal e quantos números negativos possui na minha matriz
        public static void Executar() {

            Console.WriteLine("Informe um numero que será a base da sua matrix ex. 2 = 2x2 3 = 3x3 4 = 4x4... ");
            int n = int.Parse(Console.ReadLine()!);

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine()!.Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }    
}
