using System;

namespace M02E18{
    class Program{
        static void Main(String[] args){
            int bas;
            int pot;
            Console.WriteLine("=== Calculadora de Potencias ===");
            Console.Write("Base: ");
            int.TryParse(Console.ReadLine(), out bas);
            Console.Write("Potencia: ");
            int.TryParse(Console.ReadLine(), out pot);
            double res = Math.Pow(bas, pot);
            Console.WriteLine($"O resultado de {bas} elevado a {pot} é igual a {res}");
        }
    }
}