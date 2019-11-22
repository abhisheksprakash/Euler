using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0002
    {
        public int GetSumOfFibonacciEvenValues(int lessThan)
        {
            var fibonacci = new List<int>() { 1, 2 };
            var first = 1;
            var second = 2;

            while (true)
            {
                var third = first + second;
                first = second;
                second = third;

                if (third < lessThan)
                {
                    fibonacci.Add(third);
                }
                else
                {
                    break;
                }
            }

            return fibonacci.Where(w => w % 2 == 0).Sum();
        }
    }
}
