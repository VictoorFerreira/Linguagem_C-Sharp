using System;

//namespace M02Ex003

class Program {
    static void Main(string[] args){
        float nota1 = 0f;
        float nota2 = 0f;
        Console.Write("Primeira Nota: ");
        float.TryParse(Console.ReadLine(), out nota1);
        Console.Write("Segunda Nota: ");
        float.TryParse(Console.ReadLine(), out nota2);
        float media = (nota1 + nota2) / 2;
        Console.WriteLine($"As Notas registradas foram {nota1:F1} e {nota2:F1}");
        Console.WriteLine($"A média do aluno foi {media:F1}");
        Console.ReadKey();
    }
}