using System.Collections;
using Xunit;

namespace Set
{

    public class SetTests
    {

        // Border conditions

        [Fact]
        public void Check_WhenFirstArrayIsEmpty_ShouldReturnElementsOfSecondArray()
        {

            var set = new Set();

            var addElements = new ArrayList { 1, 2, 3, 4, 5 };

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList { 1, 2, 3, 4, 5 };

            Assert.Equal(expectedResult, givenResult);
        }


        [Fact]
        public void Check_WhenSecondArrayIsEmpty_ShouldReturnElementsOfFirstArray()
        {

            var set = new Set(new ArrayList { 1, 2, 3, 4, 5 });

            var addElements = new ArrayList();

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList { 1, 2, 3, 4, 5 };

            Assert.Equal(expectedResult, givenResult);
        }

        [Fact]
        public void Check_WhenBothArraysIsEmpty_ShouldReturnEmptyArray()
        {

            var set = new Set();

            var addElements = new ArrayList();

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList();

            Assert.Equal(expectedResult, givenResult);
        }

        // Internal conditions

        [Fact]
        public void Check_WhenElementsOfBothArraysIsUnique_ShouldReturnAllElements()
        {

            var set = new Set(new ArrayList { 1, 2, 3, 4, 5 });

            var addElements = new ArrayList { 6, 7, 8, 9, 10 };

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Equal(expectedResult, givenResult);
        }

        [Fact]
        public void Check_WhenInArraysHaveSameElements_ShouldReturnAllUniqueElements()
        {

            var set = new Set(new ArrayList { 1, 2, 3, 4, 5 });

            var addElements = new ArrayList { 4, 5, 6, 7, 8 };

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.Equal(expectedResult, givenResult);
        }

        [Fact]
        public void Check_WhenArraysAreSame_ShouldReturnUniqueElements()
        {

            var set = new Set(new ArrayList { 1, 2, 3, 4, 5 });

            var addElements = new ArrayList { 1, 2, 3, 4, 5 };

            var givenResult = set.Union(addElements).Elements;

            var expectedResult = new ArrayList { 1, 2, 3, 4, 5 };

            Assert.Equal(expectedResult, givenResult);
        }




    }

}
