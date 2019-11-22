using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0009
    {
        public double ProdOfPythagoreanTriplet(double input)
        {
            for (var i = 1; i <= (input - 2); i++)
            {
                for (var j = i; j <= (input - 1); j++)
                {
                    var k = (i * i) + (j * j);
                    var sqrtK = Math.Sqrt(k);

                    if ((sqrtK % 1) == 0 && sqrtK > j && j > i && (sqrtK + j + i) == input)
                    {
                        return sqrtK * j * i;
                    }
                }
            }

            return 0;
        }
    }
}
