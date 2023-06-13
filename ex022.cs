using System;

namespace M02E22
{
    class Program
    {
        static void Main(String[] args)
        {
            float num = 0;
            Console.Write("Digite um numero real: ");
            float.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"Analisando o número {num}.");
            Console.WriteLine($"Usando o Floor() {MathF.Floor(num)}.");
            Console.WriteLine($"Usando o Ceiling() {MathF.Ceiling(num)}.");
            Console.WriteLine($"Usando o Round() {MathF.Round(num)}.");
            Console.WriteLine($"Usando o Truncate() {MathF.Truncate(num)}.");
        }
    }
}