namespace Course.ClassesAuxiliares {
    internal class Triangulo {  //nome da classe  classe é a definição de um tipo
        public double A;        // atributos da classe
        public double B;        // atributos da classe 
        public double C;        // atributos da classe

        public double Area() {  // metodos sao funçoes dentro das classes  
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
