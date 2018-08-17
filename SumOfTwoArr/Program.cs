using System;

namespace SumOfTwoArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 10, 20, 30, 40 };
            int v = 42;

            var sumNumber = new SumNumbers();
            var result = sumNumber.SumOfTwo(a, b, v);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
