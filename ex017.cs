using System;

namespace M02E17 {
    class Program {
        static void Main(String[] args) {
            int bas = 5;
            int pot = 2;

            double res = Math.Pow(bas, pot);

            Console.WriteLine($"O resultado de {bas} elevado a {pot} é igual a {res}");
        }
    }
}