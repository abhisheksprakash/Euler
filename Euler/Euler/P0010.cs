using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0010
    {
        public double SumOfPrimeBelow(double input)
        {
            double sum = 0;

            for (var i = 0; i < input; i++)
            {
                if (Util.Utilities.IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
