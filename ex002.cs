using System;
    
    //namespace M02Ex002

    class Program{

        static void Main(string[] args){
            int n1 = 0;
            int n2 = 0;
            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n2);
            
            Console.WriteLine($"Divisão Inteira {n1} / {n2} = {(int)n1 / (int)n2:D}");
        Console.WriteLine($"Divisão Real {n1} / {n2} = {(float)n1 / (float)n2:F2}");
        }
    }