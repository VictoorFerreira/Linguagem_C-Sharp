using System;
 
//namespace M02Ex001

    class Program{

        static void Main(string[] args){

            // Exemplos de operadores aritméticos
            int op1 = 0;
            int op2 = 0;
            // Entrada de dados
            Console.Write("Digite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo operando: ");
            int.TryParse(Console.ReadLine(), out op2);
            // Realizando as operações
            Console.WriteLine($"Calculando +{op1} = {+ op1}");                                     // identidade
            Console.WriteLine($"Calculando -{op1} = {- op1}");                                     // Negação
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}");                          // Adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}");                          // Subtração
            Console.WriteLine($"Calculando {op1} * {op2} = {op1 * op2}");                          // Multiplicação
            Console.WriteLine($"Calculando {op1} / {op2} = {op1 / op2} (Divisão inteira)");        // Divisão inteira
            Console.WriteLine($"Calculando {op1} / {op2} = {(float)op1 / op2:F1} (Divisão Real)"); // Divisão Real
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}");                      // Resto da divisão
            
            Console.ReadKey();
        }
    }