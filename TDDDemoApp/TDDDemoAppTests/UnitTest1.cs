using System;
using System.Collections.Generic;
using Xunit;
using TDDDemoApp;

namespace TDDDemoAppTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(0.3, 0.4, 0.7)]
        [InlineData(0.12, 0.13, 0.3)]
        public void Test1(double first, double secound, double third)
        {
            var sum = first + secound;
            var program = new CheckSum();
            var result = program.CheckSumInput(first, secound, third);
            if (sum.Equals(third)) {
                Assert.Equal("Yes", result);
            }else {
                Assert.Equal("No", result);
            }
        }
    }
}
