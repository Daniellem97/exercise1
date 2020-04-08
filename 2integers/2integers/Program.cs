using System;

namespace _2integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick a number to be added to this number");
            int num2 = int.Parse(Console.ReadLine());
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }
    }
}
