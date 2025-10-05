namespace Course.Exercios {
    public class Exe16 {
        public static void Executar() {

            // Pequena estrutura usando o modelo foreach que e uma forma de subistituir uma estrutura for.

            string[] vect = new string[] { "Maria", "Bob", "Alex" }; 
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
