using System.Collections;

namespace Core.Sample.Extensions
{
    public static class AsQueryableExtensions
    {
        public static long Product(this IEnumerable queryable)
        {
            long result = 1;

            foreach (var item in queryable)
            {
                long.TryParse(item.ToString(), out long i);
                result = result * i;
            }

            return result;
        }
    }
}
