using System;

namespace M02E16
{
    class Program
    {
        static void Main(String[] args)
        {
            int a = 5;
            int b = 3;
            int c = 8;
            int d = 4;
            
            int e1 = +a +b *4-c;
            int e2 = (a+b) /d <<2;
            bool e3 = c-b++ != --d+b%2;
                       
            Console.WriteLine($"Os valores são a={a} b={b} c={c} d={d}");
            Console.WriteLine($"As expressões são e1={e1} e2={e2} e3={e3}");
        }
    }
}