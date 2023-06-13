using System;

//namespace M02E009 - Bases numericas

class Program {
    static void Main(String[] args){
        int n = 0;
        Console.Write("Digite em base: ");
        int.TryParse(Console.ReadLine(), out n);

        Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 2)} em binario");
        Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 8)} em Octal");
        Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 10)} em Decimal");
        Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 16)} em Hexadecimal");
    }
}