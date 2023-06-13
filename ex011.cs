using System;

    namespace M02E11;
class Program{
    static void Main(string[] args){
        int op1 = 0;
        int op2 = 0;
        Console.WriteLine("OPERADORES BITWISE");
        Console.Write("Digite o primeiro numero inteiro: ");
        int.TryParse(Console.ReadLine(), out op1);
        Console.Write("Digite o segundo numero inteiro: ");
        int.TryParse(Console.ReadLine(), out op2);
        
        Console.WriteLine($"O valor de {op1} & {op2} = {op1 & op2}");
        Console.WriteLine($"O valor de {op1} | {op2} = {op1 | op2}");
        Console.WriteLine($"O valor de {op1} ^ {op2} = {op1 ^ op2}");
        Console.WriteLine($"O valor de ~{op1} = {~op1}");
        Console.WriteLine($"O valor de {op1} << {op2} = {op1 << op2}");
        Console.WriteLine($"O valor de {op1} >> {op2} = {op1 >> op2}");
    }
}