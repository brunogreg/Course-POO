using Course.ClassesAuxiliares;

namespace Course.Exercios {
    public class Exe7 {
        public static void Executar() {

            // Estrutura que solicita ao usuário que informe as 3 notas de um aluno durante um periodo escolar e informa se ele foi aprovado ou não.

            Alunos x = new();

            Console.Write("Nome do aluno: ");
            x.Nome = (Console.ReadLine()!);
            Console.WriteLine("Digite as três notas do aluno: ");
            x.A = double.Parse(Console.ReadLine()!);
            x.B = double.Parse(Console.ReadLine()!);
            x.C = double.Parse(Console.ReadLine()!);

            if (x.NotaFinal() < 60) {
                Console.WriteLine("NOTA FINAL = " + x.NotaFinal());
                Console.WriteLine("REPROVADO! ");
                Console.WriteLine("FALTARAM " + (60 - x.NotaFinal()) + " PONTOS ");
            }
            else {
                Console.WriteLine("NOTA FINAL = " + x.NotaFinal());
                Console.WriteLine("APROVADO!");
            }
        }
    }    
}
