namespace Core.Sample.Extensions
{
    public static class DoubleExtensions
    {
        public static double GetTheGreater(this double d1, double d2)
        {
            return d1 > d2 ? d1 : d2;
        }
    }
}