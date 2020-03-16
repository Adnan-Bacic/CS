using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDrivenMath.Tests
{
    [TestClass]
    public class UnitTestFibonacci
    {
        [TestMethod]
        public void BasicFibonacciTest()
        {
            // arrange
            Fibonacci myfibonacci = new Fibonacci();
            int number = 6;
            int expectedResult = 8;

            // act
            int actualResult = myfibonacci.Get(number);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // test of several values including special values. 
        [TestMethod]
        public void FibonacciValueRange()
        {
            // arrange
            Fibonacci myfibonacci = new Fibonacci();
            int numbera = 0;
            int expectedResulta = 0;
            int numberb = 1;
            int expectedResultb = 1;
            int numberc = 2;
            int expectedResultc = 1;
            int numberd = 3;
            int expectedResultd = 2;
            int numbere = 10;
            int expectedResulte = 55;
            int numberf = 20;
            int expectedResultf = 6765;
            int numberg = 46;
            int expectedResultg = 1836311903;

            // act
            int actualResulta = myfibonacci.Get(numbera);
            int actualResultb = myfibonacci.Get(numberb);
            int actualResultc = myfibonacci.Get(numberc);
            int actualResultd = myfibonacci.Get(numberd);
            int actualResulte = myfibonacci.Get(numbere);
            int actualResultf = myfibonacci.Get(numberf);
            int actualResultg = myfibonacci.Get(numberg);

            // assert
            Assert.AreEqual(expectedResulta, actualResulta);
            Assert.AreEqual(expectedResultb, actualResultb);
            Assert.AreEqual(expectedResultc, actualResultc);
            Assert.AreEqual(expectedResultd, actualResultd);
            Assert.AreEqual(expectedResulte, actualResulte);
            Assert.AreEqual(expectedResultf, actualResultf);
            Assert.AreEqual(expectedResultg, actualResultg);
        }

        // test for illegal input
        [TestMethod]
        public void FibonacciNegativeInput()
        {
            // arrange
            Fibonacci myfibonacci = new Fibonacci();
            bool oka = true;
            bool okb = true;

            // act
            try
            {
                myfibonacci.Get(-1);
                oka = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                oka = false;
            }
            try
            {
                myfibonacci.Get(47);
                okb = true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                okb = false;
            }

            //asaert
            Assert.IsFalse(oka);
            Assert.IsFalse(okb);
        }
    }
}
