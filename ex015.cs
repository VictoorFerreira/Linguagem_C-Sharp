using System;

namespace M02E15 {
    class Program {
        static void Main(String[] args) {
            string nome = null;  //string nome = "Victor"; //string nome = "null";
            Console.WriteLine($"A variavel tem valor nulo? {nome is null}"); // is(operador relacional)
        }
    }
}