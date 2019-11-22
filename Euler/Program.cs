using System;
using System.Collections.Generic;
using Core.Sample.Delegates;
using Core.Sample.Euler;
using Core.Sample.Misc;

namespace Core.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (var arg in args)
                {
                    switch (arg.ToLower())
                    {
                        case "missing_integer":
                            var missingElementsInput = new List<int>() { 0, 3, 4, 5, 7, 8, 11 };
                            var missingList = new FindMissingElements().Integers(missingElementsInput);
                            IO.Output(string.Format("Missing element(s) in {0}: {1}", String.Join(", ", missingElementsInput), String.Join(", ", missingList)));
                            break;
                        case "p0001":
                            var multiplesOf = new List<int>() { 3, 5 };
                            var o = new P0001().Of(multiplesOf, 1000);
                            IO.Output(string.Format("Multiples of {0}: {1}", String.Join(',', multiplesOf), o));
                            break;
                        case "p0002":
                            var lessThan = 4000000;
                            var sumOfFibonacciEvenValues = new P0002().GetSumOfFibonacciEvenValues(lessThan);
                            IO.Output(string.Format("Sum of the even-valued fibonacci numbers less than {0}: {1}", lessThan, sumOfFibonacciEvenValues));
                            break;
                        case "p0003":
                            var primeFactorsInput = 600851475143;
                            var maxPrimeFactor = new P0003().GetLargestPrimeFactor(primeFactorsInput);
                            IO.Output(string.Format("The largest prime factor of {0}: {1}", primeFactorsInput, maxPrimeFactor));
                            break;
                        case "p0004":
                            var digitSize = 3;
                            var largestPalindromeProduct = new P0004().LargestPalindromeProduct(digitSize);
                            IO.Output(string.Format("The largest palindrome product of two {0}-digit number: {1}", digitSize, largestPalindromeProduct));
                            break;
                        case "p0005":
                            var smallestMultipleInput = 20;
                            var smallestMultipleOutput = new P0005().DivisibleByAll(smallestMultipleInput);
                            IO.Output(string.Format("The smallest positive number that is evenly divisible by all of the numbers from 1 to {0}: {1}", smallestMultipleInput, smallestMultipleOutput));
                            break;
                        case "p0006":
                            var sumSquareDifferenceInput = 20;
                            var sumSquareDifferenceOutput = new P0006().Difference(sumSquareDifferenceInput);
                            IO.Output(string.Format("The difference between the sum of the squares and the square of the sum of the first {0}: {1}", sumSquareDifferenceInput, sumSquareDifferenceOutput));
                            break;
                        case "p0007":
                            var nthPrimeInput = 10001;
                            var nthPrimeOutput = new P0007().NthPrimeNumber(nthPrimeInput);
                            IO.Output(string.Format("The {0}th prime number: {1}", nthPrimeInput, nthPrimeOutput));
                            break;
                        case "p0008":
                            var prodOfNAdjacentNumInput = 13;
                            var prodOfNAdjacentNumOutput = new P0008().ProdOfNAdjacentNum(prodOfNAdjacentNumInput);
                            IO.Output(string.Format("The product of {0} adjacent numbers: {1}", prodOfNAdjacentNumInput, prodOfNAdjacentNumOutput));
                            break;
                        case "p0009":
                            var prodOfPythagoreanTripletInput = 1000;
                            var prodOfPythagoreanTripletOutput = new P0009().ProdOfPythagoreanTriplet(prodOfPythagoreanTripletInput);
                            IO.Output(string.Format("The product of Pythagorean Triplet: {0}", prodOfPythagoreanTripletOutput));
                            break;
                        case "p0010":
                            var sumOfPrimeBelowInput = 2000000;
                            var sumOfPrimeBelowOutput = new P0010().SumOfPrimeBelow(sumOfPrimeBelowInput);
                            IO.Output(string.Format("The sum of all primes below {0}: {1}", sumOfPrimeBelowInput, sumOfPrimeBelowOutput));
                            break;
                        default:
                            break;
                    }

                    IO.Input();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
