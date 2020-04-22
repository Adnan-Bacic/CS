using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamHandin4_Test_Driven_Development
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Average myAverage = new Average();
            double expectedResult = 2;
            int[] myArray = {1,2,3};

            //act
            double arrayAverage = myAverage.AverageCalc(myArray);

            //assert
            Assert.AreEqual(expectedResult, arrayAverage);
        }
    }
}
