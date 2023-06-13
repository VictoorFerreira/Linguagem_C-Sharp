using System;

namespace M02E23
{
    class Program
    {
        static void Main(String[] args)
        {
            float angulo = 0;
            Console.Write("Informe um angulo em graus: ");
            float.TryParse(Console.ReadLine(), out angulo);

            float rad = angulo *(MathF.PI / 180);
            float seno = MathF.Sin(rad);
            float cosseno = MathF.Cos(rad);
            float tangente = MathF.Tan(rad);

            Console.WriteLine($"O {angulo}º corresponde a {rad:F3}rad.");
            Console.WriteLine($"O seno de {angulo} é igual a {seno:F3}.");
            Console.WriteLine($"O cosseno de {angulo} é igual a {cosseno:F3}.");
            Console.WriteLine($"A tangente de {angulo} é igual a {tangente:F3}.");
            
        }
    }
}