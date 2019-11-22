using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Sample.Util
{
    public class Utilities
    {
        public static bool IsPrime(long n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static bool IsPalindrome(string str)
        {
            if (string.Compare(str, Reverse(str), true) == 0)
                return true;
            else
                return false;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
