using System;

namespace M02E21
{
    class Program
    {
        static void Main(String[] args)
        {
            float nota = 0;
            Console.Write("Digite a nota de um aluno: ");
            float.TryParse(Console.ReadLine(), out nota);
            float valid = Math.Clamp(nota, 0, 10);
            Console.WriteLine($"A nota digitada foi {nota:F2} e a nota validada é {valid:F2}.");
        }
    }
}