using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"BMM {n1},{n2} is: {BMM(n1, n2)}");
            Console.WriteLine($"KMM {n1},{n2} is: {KMM(n1, n2)}");
        }

        static int BMM(int a, int b)
        {
            return b == 0 ? a : BMM(b, a % b);
        }

        static int KMM(int a, int b)
        {
            return a * b / BMM(a, b);
        }
    }
}