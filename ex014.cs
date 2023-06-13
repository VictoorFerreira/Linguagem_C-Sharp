using System;

namespace M02E14 {
    class Program {
        static void Main(String[] args) {
            int n1 = 6;
            int n2 = 9;

            //Operação Normal
            //n1++; //Mesma coisa que n1 = n1 + 1 - Pos-incremento
            //n2--; //Mesma coisa que n2 = n2 - 1 - pos-incremento

            //int n3 = n1++; //pos-incrmento
            //int n3 = ++n1; //pré-incremento
            //int n3 = ++n1 + n2--; //pre-incrmento + pos-incremento
            int n3 = n1++ + --n2; //post-incrmento + pre-incremento

            Console.WriteLine($"n1 vale {n1} e n2 vale {n2} e n3 vale {n3}");
        }
    }
}