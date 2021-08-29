using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c;

            if (a < b)
            {
                c = a + b;
            }
            else if (a > b)
            {
                c = a - b;
            }
            else
            {
                c = a * b;
            }
            Console.WriteLine(c);
        }
    }
}
