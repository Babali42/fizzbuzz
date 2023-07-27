namespace FizzBuzz
{
    public class FizzBuzzProd
    {
        public static void Main()
        {
        }

        public static bool IsNumberMultipleOfThree(int value)
            => IsNumberMultipleOf(value, 3);


        private static bool IsNumberMultipleOf(int value, int diviser)
            => value % diviser == 0;


        public static bool IsNumberMultipleOfFive(int value)
        {
            return IsNumberMultipleOf(value, 5);
        }

        public static string Fizzbuzz(int number)
        {
            if (IsNumberMultipleOfThreeAndFive(number))
                return "FizzBuzz";
            if (IsNumberMultipleOfThree(number))
                return "Fizz";
            if (IsNumberMultipleOfFive(number))
                return "Buzz";
            return number.ToString();
        }

        internal static bool IsNumberMultipleOfThreeAndFive(int value)
            => IsNumberMultipleOfThree(value) && IsNumberMultipleOfFive(value);
    }
}