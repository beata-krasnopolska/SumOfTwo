using System.Linq;

namespace SumOfTwoArr
{
    class SumNumbers
    {
        public bool SumOfTwo(int[] a, int[] b, int v)
        {
            bool sumPossible = false;
                       
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < b.Length; j++)
                {
                    v = a[i] + b[j];
                    sumPossible = true;   
                }
            }

            return sumPossible;
        }

        public bool SumOfTwoV2(int[] firstTable, int[] secondTable, int sum)
        {
            var cos = from a in firstTable
                      from b in secondTable
                      select a + b;

            return cos.Contains(sum);
        }
    }
}
