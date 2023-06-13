using System;

//namespace M02E010 - Bases numericas

class Program
{
    static void Main(String[] args)
    {
        int n1 = 0b10010; //Binario
        int n2 = 0b_10010; //Hexadecimal

        Console.WriteLine($"O numero {n1} corresponde a {Convert.ToString(n1, toBase: 2)} em Binario");
        Console.WriteLine($"O numero {n1} corresponde a {Convert.ToString(n1, toBase: 16)} em Hexadecimal");
        //Console.WriteLine($"O valor da variavel é {n1}");
        Console.WriteLine($"Os valores das variveis são {n1} e {n2}");
    }
}