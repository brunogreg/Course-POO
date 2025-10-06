using System.Globalization;

namespace Course.Exercios {
    public class Exe22 {
        public static void Executar() {

            // Estrutura de datas e horas.

            DateTime d0 = DateTime.Now; // Data atual
            DateTime d1 = new (2025, 10, 05); // Data normal
            DateTime d2 = new (2025, 10, 05, 14, 02, 3); // Data + hora
            DateTime d3 = new (2018, 11, 25, 20, 45, 3, 500); // Data + hora + milissegundos            
            DateTime d4 = DateTime.Today; // Data de hoje com o horario zerado
            DateTime d5 = DateTime.UtcNow; // Horario de agora porem que la no GMT la no Greenwich
            DateTime d6 = DateTime.ParseExact("2025-10-05", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Voce passa uma formatação pra ele atraves de uma mascara (yyyy-MM-dd)
            DateTime d7 = DateTime.ParseExact("05-10-2025", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Voce passa uma formatação pra ele atraves de uma mascara (dd-MM-yyyy) Brasil

            Console.WriteLine("Data atual: " + d0);
            Console.WriteLine("Número de ticks: " + d0.Ticks); // O número de 'ticks' (100 nanosegundos) desde a meia noite do dia 01 de janeiro do ano 1 da era comum o DateTime pega esse numero e converte pra data que voce deseja
            Console.WriteLine("Formato de data aleatória: " + d1);
            Console.WriteLine("Formato de data aleatória dom horario: " + d2);
            Console.WriteLine("Formato de data aleatória dom horario com milessegundos: " + d3);            
            Console.WriteLine("Formato de data atual com horario zerado: " + d4);
            Console.WriteLine("Formato de data com horario GMT la no Greenwich (3 horas a mais que no Brasil: " + d5);
            Console.WriteLine("Formato de data aleatória dom horario: " + d6);
            Console.WriteLine("Formato do Brasil de data com horario: " + d7);

        }
    }    
}
