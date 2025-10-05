namespace Course.ClassesAuxiliares {
    internal class Retangulo {
        public static double Largura;
        public static double Altura;

        public static double Area() {  // metodos sao funçoes dentro das classes  
            return Largura * Altura;
        }

        public static double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public static double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
