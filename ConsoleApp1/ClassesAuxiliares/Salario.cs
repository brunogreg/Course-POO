using System.Globalization;

namespace Course.ClassesAuxiliares {
    internal class Salario {
        public string? Nome;
        public double Valor;
        public double Imposto;

        public double SalarioLiquido() {  // metodos sao funções dentro das classes  
            return Valor - Imposto;
        }
        public void AumentarSalario(double quantidade) { // Void porque é uma função com retorno vazio, ela simplesmente exerce o que tem que fazer e depois
            Valor += Valor * (quantidade / 100.0);
        }

        public override string ToString() {
            return "O funcionário "
                + Nome
                + " Vai recebe livre de impostos $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
