using System;
using System.Collections;
using System.Linq;
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


        [Fact]
        public void MutationTest()
        {

            const int upperNumOfElemForFirstSet = 6;
            const int upperNumOfElemForSecondSet = 7;

            const int minElem = 0;
            const int maxElem = 300;

            var random = new Random();

            var firstArrayList = new ArrayList();
            var secondArrayList = new ArrayList();

            // Fill arrays by random elements
            for (var count = 0; count < upperNumOfElemForFirstSet; count++)
            {
                var elem = random.Next(minElem, maxElem);
                firstArrayList.Add(elem);
            }

            for (var count = 0; count < upperNumOfElemForSecondSet; count++)
            {
                var elem = random.Next(minElem, maxElem);
                secondArrayList.Add(elem);
            }

            var set = new Set(firstArrayList);

            // In expectedResult using native method of union instead method of Set for givenResult

            var givenResult = set.Union(secondArrayList).Elements.ToArray();
            var expectedResult = firstArrayList.ToArray().Union(secondArrayList.ToArray()).ToArray();

            Assert.Equal(givenResult, expectedResult);

        }

        [Fact]
        public void IntervalTest()
        {

            var numberOfIntervals = 10;
            var step = 30;

            var firstArrayList = new ArrayList();
            var secondArrayList = new ArrayList();

            var random = new Random();

            for (var interval = 0; interval < numberOfIntervals; interval++)
            {
                var elem1 = random.Next(step * interval, step * (interval + 1));
                var elem2 = random.Next(step * interval, step * (interval + 1));

                firstArrayList.Add(elem1);
                secondArrayList.Add(elem2);
            }

            var set = new Set(firstArrayList);

            var givenResult = set.Union(secondArrayList);

            var expectedResult = firstArrayList.ToArray().Union(secondArrayList.ToArray());

            Assert.Equal(givenResult.Elements.ToArray(), expectedResult);

        }

    }

}
