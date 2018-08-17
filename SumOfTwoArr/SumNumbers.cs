using System;

namespace SumOfTwoArr
{
    class SumNumbers
    {
          public bool SumOfTwo(int[] a, int[] b, int v)
        {
            v = 0;

            bool sumPossible = false;
                       
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < b.Length; j++)
                {
                    v = a[i] + b[i];
                    sumPossible = true;
                                   
                }
            }
            if(sumPossible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
