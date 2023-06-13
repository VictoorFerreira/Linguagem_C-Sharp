using System;

//namespace M02E007 - Idade para votar - Exercicios Extra

class Program{
    static void Main(String[] args){
        int idade = 0;
        
        //Entrada de dados
        Console.Write("Qual é a sua idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        
        //Calculo da Média e situação
        bool sit001 = idade >=0 && idade < 16;
        bool sit002 = idade >=16 && idade < 18;
        bool sit003 = idade >=18 && idade < 65;
        bool sit004 = idade >=65;

        //Mostrando Resultados
        Console.WriteLine($"Impossivel votar? {sit001}");
        Console.WriteLine($"Opcional votar? {sit002}");
        Console.WriteLine($"Obrigatório votar? {sit003}");
        Console.WriteLine($"Opcional votar? {sit004}");
    
        Console.ReadKey();
    }
}