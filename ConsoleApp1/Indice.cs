using Course.Exercios;

namespace Course {
    public class Indice {
        public static void Executar() {

            string continuar;

            do {
                Console.Clear(); // Limpa a tela ANTES de mostrar o menu

                // Mostra o índice
                Console.WriteLine("Bem-vindo à lista de Exercícios com Resoluções em C#, focado em POO: ");
                Console.WriteLine();
                Console.WriteLine("ÍNDICE:");
                Console.WriteLine();
                Console.WriteLine("01 - Estrutura de comparação de triângulos");
                Console.WriteLine("02 - Estrutura de comparação de pessoas ");
                Console.WriteLine("03 - Estrutura de comparação de salários ");
                Console.WriteLine("04 - Estrutura de controle de estoque ");
                Console.WriteLine("05 - Estrutura de medida de retângulos");
                Console.WriteLine("06 - Estrutura de cálculo de salário");
                Console.WriteLine("07 - Estrutura de cálculo de notas de trimestre");
                Console.WriteLine("08 - Estrutura de conversão de dólar para reais");
                Console.WriteLine("09 - Estrutura de saque e deposito bancário");
                Console.WriteLine("10 - Estrutura de struct (apenas pra observar)");
                Console.WriteLine("11 - Estrutura de uma variável tipo valor recebendo null (apenas pra observar)");
                Console.WriteLine("12 - Estrutura de vetor que calcula a média das alturas informadas");
                Console.WriteLine("13 - Estrutura de vetor que calcula a média dos preços dos produtos informados");
                Console.WriteLine("14 - Estrutura de locação de quartos de um hotel");
                Console.WriteLine("15 - Estrutura de calculadora utilizando vetor e modificadores params/ref/out");
                Console.WriteLine("16 - Estrutura de parâmetros variáveis 'params' (apenas pra observar)");
                Console.WriteLine("17 - Estrutura de listas e modificações");
                Console.WriteLine("18 - Estrutura de listas para dar aumento a funcionários");
                Console.WriteLine("19 - Estrutura de Matrizes para informar a diagonal principal");
                Console.WriteLine("20 - Estrutura de Expressão condicional ternária");
                Console.WriteLine("21 - Estrutura de ToString ferramentas");
                Console.WriteLine("22 - Estrutura de datas e horas DateTime (Para observar)");
                Console.WriteLine();

                // Escolha do exercício
                Console.Write("Escolha um dos modelos de estrutura acima (1 a 22): ");
                string opcao = Console.ReadLine()!;
                Console.WriteLine("Você escolheu o modelo de estrutura " + opcao);

                // Limpa a tela ANTES de executar o exercício
                Console.Clear();

                // Executa o exercício escolhido
                switch (opcao) {
                    case "1": Exe1.Executar(); break;
                    case "2": Exe2.Executar(); break;
                    case "3": Exe3.Executar(); break;
                    case "4": Exe4.Executar(); break;
                    case "5": Exe5.Executar(); break;
                    case "6": Exe6.Executar(); break;
                    case "7": Exe7.Executar(); break;
                    case "8": Exe8.Executar(); break;
                    case "9": Exe9.Executar(); break;
                    case "10": Exe10.Executar(); break;
                    case "11": Exe11.Executar(); break;
                    case "12": Exe12.Executar(); break;
                    case "13": Exe13.Executar(); break;
                    case "14": Exe14.Executar(); break;
                    case "15": Exe15.Executar(); break;
                    case "16": Exe16.Executar(); break;
                    case "17": Exe17.Executar(); break;
                    case "18": Exe18.Executar(); break;
                    case "19": Exe19.Executar(); break;
                    case "20": Exe20.Executar(); break;
                    case "21": Exe21.Executar(); break;
                    case "22": Exe22.Executar(); break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                // Pergunta se quer repetir
                Console.WriteLine();
                Console.Write("Deseja realizar outro exercício? (s/n): ");
                continuar = Console.ReadLine()!;

                // Só limpa a tela se o usuário quiser continuar
                if (continuar.ToLower() == "s") {
                    Console.Clear();
                }

            } while (continuar.ToLower() == "s");

            Console.WriteLine("Obrigado por usar o programa. Até mais!");
        }
    }
}
