using MyMath;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyMathTests
{
    public class AwesomMathTests
    {
        [Fact(DisplayName ="Return all divisor from a int number")]
        public void GetAllDivisor()
        {
            //arrange
            int number = 40;
            var expectedDivisor = new List<int> { 1, 2, 4, 5, 6, 10, 20, 40 };

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.NotNull (actualDivisor);
            Assert.Equal(8, actualDivisor.Count());
            Assert.Equal(expectedDivisor, actualDivisor);
        }
    }
}
