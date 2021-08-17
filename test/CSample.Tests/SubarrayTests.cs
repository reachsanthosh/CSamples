using Xunit;
using CSample.Puzzles;
using System.Collections.Generic;

namespace CSample.Tests
{
    public class SubarrayTests
    {
        private SubArray array;
        private List<int> chocBar;

        public SubarrayTests()
        {
          chocBar = new List<int>{2,2,1,3,2}; 
          int month = 2, day = 4; 
          array = new SubArray(chocBar, month, day);
        }

        [Fact]
        public void TestNoOfWaysReturnsTwo()
        {
            Assert.Equal(2,array.NoOfWaysBarDivided());
        }

        [Fact]
        public void TestNoOfWaysReturnsNotTwo()
        {
            chocBar = new List<int> { 2, 2, 1, 3 };
            int month = 2, day = 4;
            array = new SubArray(chocBar, month, day);
            Assert.NotEqual(1, array.NoOfWaysBarDivided());
        }
    }
}
