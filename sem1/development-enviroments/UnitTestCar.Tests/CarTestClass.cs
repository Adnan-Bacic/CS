using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCar
{
    [TestClass]
    public class CarTestClass
    {
        [TestMethod]
        public void TestCar()
        {
            //arrange
            Car myCar = new Car("Reanult", "Flamered");
            Car myOtherCar = new Car("Volvo");

            //act
            string myModel = myCar.Model;
            string myColor = myCar.Color;

            string myOtherModel = myOtherCar.Model;
            string myOtherColor = myOtherCar.Color;

            //assert
            Assert.AreEqual("Reanult", myModel);
            Assert.AreEqual("Flamered", myColor);

            Assert.AreEqual("Volvo", myOtherModel);
            Assert.IsNull(myOtherColor);
        }

        //new test
        [TestMethod]
        public void TestChangeColor()
        {
            //arrange - set up
            Car myCar = new Car("Reanult", "Flamered");
            Car myOtherCar = new Car("Volvo");
            Car myThirdCar = new Car("Reanult", "Flamered");
            Car myForthCar = new Car("Volvo");

            //act - use method in car.cs
            myCar.ChangeColor("blue");
            string myColor = myCar.Color;

            myOtherCar.ChangeColor("blue");
            string myOtherColor = myOtherCar.Color;

            myThirdCar.ChangeColor("pink");
            string myThirdColor = myThirdCar.Color;

            myForthCar.ChangeColor("pink");
            string myForthColor = myForthCar.Color;


            //assert - see if we get the correct result
            Assert.AreEqual("blue", myColor);
            Assert.AreEqual("blue", myOtherColor);
            Assert.AreEqual("Flamered unchanged", myThirdColor);
            Assert.AreEqual(" unchanged", myForthColor);
        }

        [TestMethod]
        public void TestToString()
        {
            //arrange
            Car myCar = new Car("Reanult", "Flamered");
            Car myOtherCar = new Car("Volvo");

            //act
            string myResult = myCar.ToString();
            string myOtherResult = myOtherCar.ToString();

            //assert
            Assert.AreEqual("Reanult; color : Flamered", myResult);
            Assert.AreEqual("Volvo; color unknown", myOtherResult);
        }
    }
}