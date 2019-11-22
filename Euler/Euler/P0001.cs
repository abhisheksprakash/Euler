using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0001
    {
        public int Of(List<int> numbers, int below)
        {
            var foundItems = new List<int>();

            foreach (var number in numbers)
            {
                for (var i = 1; ; i++)
                {
                    var product = number * i;

                    if (product < below)
                    {
                        foundItems.Add(product);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return foundItems.Distinct().Sum();
        }        
    }
}
