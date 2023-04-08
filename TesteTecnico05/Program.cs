using System;

namespace testeTecnico05 {
    class Program {
        static void Main(string[] args) {
            static void Main(string[] args) {
                string original = "exemplo"; // string original
                string invertida = ""; // string invertida

                for (int i = original.Length - 1; i >= 0; i--) {
                    invertida += original[i];
                }

                Console.WriteLine("String original: {0}", original);
                Console.WriteLine("String invertida: {0}", invertida);
            }
        }
    }
}
