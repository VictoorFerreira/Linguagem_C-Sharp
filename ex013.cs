using System;
namespace M02E13 {
    class Program  {
        static void Main(string[] args) {
            int lotacao = 10;
            int total = 4;
            int grupo = 0;

            Console.Write("Quantas pessoas chegaram: ");
            int.TryParse(Console.ReadLine(), out grupo);
            
            total += grupo; //mesma coisa de total = total + grupo

            Console.WriteLine($"Chegando um grupo de {grupo} pessoas, agora temos {total} de pessoas na festa");
            Console.WriteLine($"Lotou a balada? {total >= lotacao}"); 
        }
    }
}