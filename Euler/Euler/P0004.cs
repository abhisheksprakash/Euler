using Core.Sample.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Sample.Euler
{
    public class P0004
    {
        public double LargestPalindromeProduct(double size)
        {
            if (size <= 0)
                return 0;
            if (size == 1)
                return 9;

            double smallestNumber = 1, largestNumber = 9, product = 0;
            smallestNumber = Math.Pow(10, size - 1);
            largestNumber = Math.Pow(10, size) - 1;

            for (var i = largestNumber; i >= smallestNumber; i--)
            {
                for (var j = largestNumber; j >= smallestNumber; j--)
                {
                    var palindromeProduct = i * j;

                    if (Utilities.IsPalindrome(palindromeProduct.ToString()) && palindromeProduct > product)
                    {
                        product = palindromeProduct;
                    }
                }
            }

            return product;
        }
    }
}
