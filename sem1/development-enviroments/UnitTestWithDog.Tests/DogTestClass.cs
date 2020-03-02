using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWithDog.Tests
{
    // Note, that sometimes there is no "public" when the class is created
    [TestClass]
    public class DogTestClass
    {
        [TestMethod]
        public void TestDog()
        {
            // a bit lazy : More than one test in TestMethod
            // arrnge
            Dog mydog = new Dog("Lady", 7);
            Dog myotherdog = new Dog("Tramp");

            // act
            string myname = mydog.Name;
            int? myage = mydog.Age;
            string myothername = myotherdog.Name;
            int? myotherage = myotherdog.Age;

            // assert
            Assert.AreEqual("Lady", myname);
            Assert.AreEqual(7, myage);
            Assert.AreEqual("Tramp", myothername);
            Assert.IsNull(myotherage);
        }

        [TestMethod]
        public void TestSetNewAge()
        {
            // arrnge
            Dog mydog = new Dog("Lady", 7);
            Dog myotherdog = new Dog("Tramp");

            // act
            mydog.Age = 0;
            int? myage = mydog.Age;
            myotherdog.Age = 0;
            int? myotherage = myotherdog.Age;

            // assert
            Assert.AreEqual(0, myage);
            Assert.AreEqual(0, myotherage);
        }

        

        [TestMethod]
        public void TestIncreaseAge()
        {
            // arrnge
            Dog mydog = new Dog("Lady", 7);
            Dog myotherdog = new Dog("Tramp");

            // act
            mydog.IncreaseAge();
            int? myresult = mydog.Age;
            myotherdog.IncreaseAge();
            int? myotherresult = myotherdog.Age;

            // assert
            Assert.AreEqual(8, myresult);
            Assert.IsNull(myotherresult);
        }

        [TestMethod]
        public void TestSayhello()
        {
            // arrnge
            Dog mydog = new Dog("Lady", 7);  // no age involved - only Lady

            // act
            string myresult = mydog.SayHello("TOR");

            // assert
            Assert.AreEqual("Woof ! TOR", myresult);
        }

        [TestMethod]
        public void TestToString()
        {
            // arrnge
            Dog mydog = new Dog("Lady", 7);
            Dog myotherdog = new Dog("Tramp");
            Dog myextradog = new Dog("Pluto", 1);

            // act
            string myresult = mydog.ToString();
            string myotherresult = myotherdog.ToString();
            string myextraresult = myextradog.ToString();

            // assert
            Assert.AreEqual("Lady is 7 years old", myresult);
            Assert.AreEqual("Tramp; age unknown", myotherresult);
            Assert.AreEqual("Pluto is 1 year old", myextraresult);
        }
    }
}
