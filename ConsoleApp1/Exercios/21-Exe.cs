namespace Course.Exercios {
    public class Exe21 {
        public static void Executar() {

            string original = "abcde FGHIJ ABC abc DEFG "; // Em C# string e uma variavel imutavel
            string s1 = original.ToUpper(); // Para converter em Maiusculo
            string s2 = original.ToLower(); // Para converter em minusculo
            string s3 = original.Trim();  // Para remover os espaços em branco
            int n1 = original.IndexOf("bc"); // Procura a primeira ocorrencia do pedaço 'bc' dentro da minha string original
            int n2 = original.LastIndexOf("bc"); // Procura a ultima ocorrencia do pedaço 'bc' dentro da minha string original
            string s4 = original.Substring(3); // Para cortar a minha string apartir do meu parametro passado
            string s5 = original.Substring(3, 5); // Vai extrair 5 caracteres apartir do indice 3
            string s6 = original.Replace('a', 'x'); // Troca todos os caracteres 'a' da minha string 'original' por 'x'
            string s7 = original.Replace("abc", "xy"); // Troca todas as ocorrencias 'abc' por 'xy
            bool b1 = String.IsNullOrEmpty(original); // Testa se minha variavel original é nula ou vazia ( só serve para strig)
            bool b2 = String.IsNullOrWhiteSpace(original); // Testa se a variavel é nula ou espaço em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }    
}
