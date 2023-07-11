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

        [Test]
        public void ShouldOneBeStringOne()
        {
            Assert.AreEqual(FizzBuzzProd.Fizzbuzz(1), "1");
        }
    }
}