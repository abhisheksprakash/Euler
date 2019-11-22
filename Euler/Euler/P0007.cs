using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0007
    {
        public long NthPrimeNumber(long nValue)
        {
            // 2 is a prime, so add it already.
            IList<long> primes = new List<long>() { 2 };
            
            // start from 3, since 2 is already added.
            long i = 3;

            while (true)
            {
                if (Util.Utilities.IsPrime(i))
                {
                    primes.Add(i);

                    if (primes.Count == nValue)
                    {
                        break;
                    }
                }
                i += 2;
            }

            return primes.Max();
        }
    }
}
