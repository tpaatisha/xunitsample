using System;

namespace xUnitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new MathClass();
            Console.WriteLine("Enter Value A:");
            var A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value B:");
            var B = Int32.Parse(Console.ReadLine());
            var C = math.Sum(A,B);
            var D = math.Minus(A, B);
            Console.WriteLine("The sum is: " + C.ToString());
            Console.WriteLine("The Difference is: " + D.ToString());
        }
    }
}
