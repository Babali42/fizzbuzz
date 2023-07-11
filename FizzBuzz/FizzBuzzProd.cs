using NUnit.Framework;
using System;

namespace FizzBuzz
{
    
    public class FizzBuzzProd
    {
        public void Main()
        {

        }

        public static bool IsNumberMultipleOfThree(int value)
        {
            return (value % 3) == 0;
        }

        public static string Fizzbuzz(int number)
        {
            return number.ToString();
        }
    }
}