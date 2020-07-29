using MyMath;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyMathTests
{
    public class AwesomMathTests
    {
        [Fact(DisplayName ="Given number 40 should return a list containing 8 divisor")]
        public void Given40ShouldReturnListWithNumbers()
        {
            //arrange
            int number = 40;
           
            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(8, actualDivisor.Count());
        }

        [Fact(DisplayName = "Given number 40 should return a list and match with the specified 8 divisor")]
        public void Given40ShouldReturnListAndMatchWithSpecifiedNumbers()
        {
            //arrange
            int number = 40;
            var expectedDivisor = new List<int> { 1, 2, 4, 5, 8, 10, 20, 40 };

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(expectedDivisor, actualDivisor);
        }
    }
}
