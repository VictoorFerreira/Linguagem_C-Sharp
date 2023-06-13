using System;

namespace M02E20
{
    class Program
    {
        static void Main(String[] args) {
            int n1 = 8;
            int n2 = 10;
            Console.WriteLine($"O maior valor entre {n1} e {n2} é {MathF.Max(n1, n2)}");
            Console.WriteLine($"O menor valor entre {n1} e {n2} é {MathF.Min(n1, n2)}");
        }
    }
}