using System.Collections.Generic;

namespace Course.Exercios {
    public class Exe17 {
        public static void Executar() {

            // Estrutura de listas e modificações

            List<string> list = new List<string>(); // Listas sao parecidas com vetores porem podem ja ser instanciadas vazias

            list.Add("Maria"); // Add é para adicionar um elemento ao final da minha lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // Inset é para adicionar um elemento em uma posição especifica da minha lista (2, "Marco")

            foreach (string obj in list) {  // Estrutura para listar os elementos da minha lista
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);  // List.count para informar o tamanho da minha lista

            string s1 = list.Find(x => x[0] == 'A')!; //List.Find procura na minha lista baseado no predicado " parametro "( condição que eu passei no caso x => x[0] == 'A') pedindo o obejeto x tal que x na posiçã [0] = A maiusculo
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A')!; //List.Last procura na minha lista ( o ultimo elemento) baseado no predicado " parametro "( condição que eu passei no caso x => x[0] == 'A') pedindo o obejeto x tal que x na posiçã [0] = A maiusculo
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // list.FindIndex usa se para procurar uma posição informada pelo meu predicado " parametro " (x => x[0] == 'A') me retornando a posição dele tipo position 1...2...3
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // list.FindLastIndex procura a ultima ocorrencia onde a ultima posição começa com "A"
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); //Filtra a lista criando uma nova lista contendo os elementos que satisfaçam o predicado informado (x => x.Length == 5) onde o objeto tenha 5 caracters
            Console.WriteLine("---------------------");

            foreach (string obj in list2) { // Para listar os elementos da minha lista2
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); // List.Remove tira da lista um elemento informado
            Console.WriteLine("---------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // list.RemoveAll remove todos os elementos seguindo o predicado que informei (x => x[0] == 'M') todo que começam com 'M'
            Console.WriteLine("---------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2); // List.RemoveAt remove da minha lista elementos diretamento no predicato informado
            Console.WriteLine("---------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); // List.RemoveRange remove da minha lista elementos diretamento no predicato informado nesse caso remove dois elementos apartir da minha posição dois (2 posição , 2 elementos)
            Console.WriteLine("---------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
