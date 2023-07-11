using NUnit.Framework;
using System;

namespace FizzBuzz
{
    
    public class FizzBuzzProd
    {
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        public static bool IsNumberMultipleOfThree(int value)
        {
            return IsNumberMultipleOf(value, 3);
        }

        private static bool IsNumberMultipleOf(int value, int diviser)
        {
            return (value % diviser) == 0;
        }

        public static bool IsNumberMultipleOfFive(int value)
        {
            return IsNumberMultipleOf(value, 5);
        }

        public static string Fizzbuzz(int number)
        {
            return number.ToString();
        }

        internal static bool IsNumberMultipleOfThreeAndFive(int value)
        {
            return IsNumberMultipleOfThree(value) && IsNumberMultipleOfFive(value);
        }
    }
}