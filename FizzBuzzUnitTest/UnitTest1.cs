using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This method test multiple three numbers
        /// </summary>
        [TestMethod]
        public void MultipleThree()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // use any number that is multiple three to pass the test
            int multipleThree = 15;
            string Actual = FizzBuzzObj.MultipleThree(multipleThree);
            string Expected = "Fizz";
            Assert.AreEqual(Expected, Actual );

        }

        /// <summary>
        /// This method test numbers that are not multiple three 
        /// </summary>
        [TestMethod]
        public void NotMultipleThree()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is not multiple 3
            int notMultipleThree = 11;
            string actualResultMutiple3 = FizzBuzzObj.MultipleThree(notMultipleThree);
            string expectedMultipleThree = "";
            Assert.AreEqual( expectedMultipleThree, actualResultMutiple3);

        }

        /// <summary>
        /// This method test multiple Five numbers
        /// </summary>
        [TestMethod]
        public void MultipleFive()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is multiple 5 
            int multipleFive = 15;
            string resultMutiple5 = FizzBuzzObj.MultipleFive(multipleFive);
            string expectedMultipleFive = "Buzz";
            Assert.AreEqual(resultMutiple5, expectedMultipleFive);
        }

        /// <summary>
        /// This method test numbers that are not multiple three
        /// </summary>
        [TestMethod]
        public void NotMultipleFive()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is not multiple 5
            int multipleFive = 14;
            string ActualResultMutiple5 = FizzBuzzObj.MultipleFive(multipleFive);
            string expectedMultipleFive = "";
            Assert.AreEqual( expectedMultipleFive , ActualResultMutiple5);
        }

        /// <summary>
        /// This method test output of numbers that are mutiple 3 and 5
        /// output should be FizzBuzz
        /// </summary>
        [TestMethod]
        public void FizzBuzzOut()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is multiple 5 and 3
            int IntputNumber = 15;
            string actualResult = FizzBuzzObj.Output(IntputNumber);
            string expectedResult = "FizzBuzz";
            Assert.AreEqual(actualResult, expectedResult);
        }

        /// <summary>
        /// This method test output of numbers that are mutiple 3
        /// out put should be Fizz
        /// </summary>
        [TestMethod]
        public void FizzOut()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is multiple 3 not 5
            int IntputNumber = 21;
            string actualResult = FizzBuzzObj.Output(IntputNumber);
            string expectedResult = "Fizz";
            Assert.AreEqual(actualResult, expectedResult);
        }

        /// <summary>
        /// This method test output of numbers that are mutiple 5
        /// out put should be Buzz
        /// </summary>
        [TestMethod]
        public void BuzzOut()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Any number that is multiple 5 not 3
            int IntputNumber = 25;
            string actualResult = FizzBuzzObj.Output(IntputNumber);
            string expectedResult = "Buzz";
            Assert.AreEqual(actualResult, expectedResult);
        }

        /// <summary>
        /// This method test numbers that are not multiple 3 nor multiple 5
        /// the output should be same number with string format
        /// </summary>
        [TestMethod]
        public void NoChangeOut()
        {
            FizzBuzz FizzBuzzObj = new FizzBuzz();
            // Use any number that is not multiple 3 and 5
            int IntputNumber = 22;
            string actualResult = FizzBuzzObj.Output(IntputNumber);
            string expectedResult = IntputNumber.ToString();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }

    
}
