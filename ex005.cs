using System;

//namespace M02E005 - Operadores Logicos

class Program{
    static void Main(String[] args){
        bool p = true;
        bool q = true;

        //Saida dos Resultados
        Console.WriteLine($"{p} = {!p}");
        Console.WriteLine($"{p} e {q} = {p && q}");
        Console.WriteLine($"{p} ou {q} = {p || q}");
        Console.ReadKey();
    }
}