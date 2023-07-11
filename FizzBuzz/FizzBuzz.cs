using NUnit.Framework;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static void Main()
        {
            
        }
        
        [TestCase(3, true)]
        [TestCase(5, false)]
        [TestCase(9, true)]
        [TestCase(10, false)]
        public void ShouldBeMultipleOfThree(int value, bool expected)
        {
            //Arrange act
            Assert.AreEqual(expected, FizzBuzzProd.IsNumberMultipleOfThree(value));
        }
    }
}