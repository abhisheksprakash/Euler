using System.Collections.Generic;
using System.Linq;

namespace Core.Sample.Misc
{
    public class FindMissingElements
    {
        public List<int> Integers(List<int> input)
        {
            var missingElements = new List<int>();

            var low = input.Min();
            var high = input.Max();

            for (var i = low; i <= high; i++)
            {
                var missingElementCheck = i + 1;

                while (!input.Contains(missingElementCheck) && missingElementCheck < high)
                {
                    missingElements.Add(missingElementCheck++);
                    i++;
                }
            }

            return missingElements;
        }
    }
}
