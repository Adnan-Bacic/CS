using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivenMath.Tests
{
    [TestClass]
    public class UnitTestRooter
    {
        // test a single example
        [TestMethod]
        public void BasicRooterTest()
        {
            // arrange
            // create an instance to test
            Rooter myrooter = new Rooter();
            // define a test input and output
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;

            // act
            // run the method to test
            double actualResult = myrooter.SquareRoot(input);

            // assert
            // verify the result
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        // test a range of values. 2 test ~ multiplication by 10. Exponent range -8 to 8 ~ 32 tests. 
        [TestMethod]
        public void RooterValueRange()
        {
            // arrange
            // create an instance to test
            Rooter myrooter = new Rooter();
            // try a range of values
            for (double expectedResult = 1e-8; expectedResult < 1e+8; expectedResult = expectedResult * 3.2)
            {
                RooterOneValue(myrooter, expectedResult);
            }
        }

        private void RooterOneValue(Rooter myrooter, double expectedResult)
        {
            // arrange
            double input = expectedResult * expectedResult;

            // act
            double actualResult = myrooter.SquareRoot(input);

            // assert
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        // test for negative input
        [TestMethod]
        public void RooterNegativeInput()
        {
            // arrange
            Rooter rooter = new Rooter();
            bool ok = true;

            // act
            try
            {
                rooter.SquareRoot(-10);
                ok = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                ok = false;
            }

            //asaert
            Assert.IsFalse(ok);
        }

    }
}
