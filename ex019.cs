using System;

namespace M02E19{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("=== Calculadora de Raizes ===");
            int num;
            Console.Write("Numero: ");
            int.TryParse(Console.ReadLine(), out num);
            double rq = Math.Sqrt(num);
            double rc = Math.Cbrt(num);
            Console.WriteLine($"A raiz quadrada de {num} é igual a {rq:F2}");
            Console.WriteLine($"A raiz cubica de {num} é igual a {rc:F2}");
        }
    }
}