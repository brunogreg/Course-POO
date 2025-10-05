namespace Course.ClassesAuxiliares {
    internal class Alunos {
        public string Nome;
        public double A;
        public double B;
        public double C;

        public double NotaFinal() {
            return A + B + C;
        }
    }
}
