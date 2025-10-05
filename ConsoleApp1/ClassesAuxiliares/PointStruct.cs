namespace Course.ClassesAuxiliares {
    struct PointStruct {    // Exemplo de uma estrutura struct tipo valor, para representar um ponto no plano 2d
        public double x;
        public double y;

        public override string ToString() {
            return "(" + x + ", " + y + ")";
        }

    }
}
