using Core.Sample.Util;
using System.Collections.Generic;
using System.Linq;

namespace Core.Sample.Euler
{
    public class P0003
    {
        public long GetLargestPrimeFactor(long input)
        {
            var primeFactors = new List<long>();

            if (input % 2 == 0)
                primeFactors.Add(2);

            // if a number is even then 2 is one of it's factor, so increment by 2.
            // start from 3, since 1 is not prime and check for 2 is already done.
            for (long divisor = 3; divisor <= input / 2; divisor += 2)
            {
                if (input % divisor == 0 && Utilities.IsPrime(divisor))
                {
                    primeFactors.Add(divisor);

                    // check if you need to stop processing. you can do that by multiplying
                    // all values in the final list. if that value is greater than or equal
                    // to the original input, that is the end.
                    long prod = 1;

                    foreach (var primeFactor in primeFactors)
                        prod *= primeFactor;

                    if (prod >= input)
                        break;
                }
            }

            return primeFactors.Max();
        }        
    }
}
