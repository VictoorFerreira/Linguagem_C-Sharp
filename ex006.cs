using System;

//namespace M02E006 - Expressão Mistas

class Program{
    static void Main(String[] args){
        float n1 = 0f;
        float n2 = 0f;
        //Entrada de dados
        Console.Write("Primeira nota do aluno: ");
        float.TryParse(Console.ReadLine(), out n1);
        Console.Write("Segunda nota do aluno: ");
        float.TryParse(Console.ReadLine(), out n2);
        
        //Calculo da Média e situação
        float média = (n1 + n2) / 2;
        bool sit001 = média >=0 && média < 4.0;
        bool sit002 = média >=4 && média < 7.0;
        bool sit003 = média >=7 && média <= 10.0;

        //Mostrando Resultados
        Console.WriteLine($"A média do aluno foi {média:F1}");
        Console.WriteLine($"Aluno está Reprovado? {sit001}");
        Console.WriteLine($"Aluno está Recuperação? {sit002}");
        Console.WriteLine($"Aluno está Aprovado? {sit003}");
    
        Console.ReadKey();
    }
}