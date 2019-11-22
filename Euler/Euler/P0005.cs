using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0005
    {
        public long DivisibleByAll(int lessThan)
        {
            var multiplier = 1;
            long product = 0;
            var condition = true;

            while (condition)
            {
                product = lessThan * multiplier++;

                for (var i = lessThan; i > 1; i--)
                {
                    if (product % i == 0)
                        condition = false;
                    else
                    {
                        condition = true;
                        break;
                    }
                }
            }

            return product;
        }
    }
}
