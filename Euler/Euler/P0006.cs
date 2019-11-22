using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0006
    {
        public long Difference(int lessThan)
        {
            long sum = 0, sumOfSquares = 0;

            for (var i = 1; i <= lessThan; i++)
            {
                sum += i;
                sumOfSquares += (long)Math.Pow(i, 2);
            }

            return (long)Math.Pow(sum, 2) - sumOfSquares;
        }
    }
}
