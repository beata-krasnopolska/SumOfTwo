using System;
using System.Linq;

namespace SumOfTwoArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Enumerable.Range(1, 100000).ToArray();
            int[] b = Enumerable.Range(1, 10000).ToArray();
            int v = 42;

            var sumNumber = new SumNumbers();
            var result = sumNumber.SumOfTwo(a, b, v);
            var result2 = sumNumber.SumOfTwoV2(a, b, v);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
