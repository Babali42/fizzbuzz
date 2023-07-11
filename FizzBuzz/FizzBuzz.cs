using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzz
    {
        [TestCase(3, true)]
        [TestCase(5, false)]
        [TestCase(9, true)]
        [TestCase(10, false)]
        public void ShouldBeMultipleOfThree(int value, bool expected)
        {
            //Arrange act
            Assert.AreEqual(expected, FizzBuzzProd.IsNumberMultipleOfThree(value));
        }
        
        [TestCase(3, false)]
        [TestCase(5, true)]
        [TestCase(9, false)]
        [TestCase(10, true)]
        public void ShouldBeMultipleOfFive(int value, bool expected)
        {
            //Arrange act
            Assert.AreEqual(expected, FizzBuzzProd.IsNumberMultipleOfFive(value));
        }


        [TestCase(3, false)]
        [TestCase(5, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(15, true)]
        public void ShouldBeMultipleOfThreeAndFive(int value, bool expected)
        {
            //Arrange act
            Assert.AreEqual(expected, FizzBuzzProd.IsNumberMultipleOfThreeAndFive(value));
        }

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(7, "7")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void ShouldOneBeStringOne(int value, string expected)
        {
            //Arrange act
            Assert.AreEqual(FizzBuzzProd.Fizzbuzz(value), expected);
        }
    }
}