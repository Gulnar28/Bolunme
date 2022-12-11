using System;

namespace Bolunme
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int bolunme = a % b;
            Console.WriteLine($"{a}%{b}={bolunme}");
            ;
        }
    }
}
