using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace examhandin2.Tests
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            //arrage
            ListXwithErrors myList = new ListXwithErrors();

            //act
            myList.Add("a");
            myList.Add("b");
            int mySize = myList.Length(); //is always 0

            //assert
            Assert.AreEqual(0, mySize);
        }

        [TestMethod]
        public void TestAdd()
        {
            string myException;
            try
            {
                //arrange
                ListXwithErrors myList = new ListXwithErrors();

                //act
                myList.Add("a");
                myList.Add("b");
                myList.Add("c");
                myList.Add("last_item");

                //assert
                Assert.AreEqual(0, myList.Length()); //0 because it doesnt increment
                Assert.AreEqual("last_item", myList.Get(3)); //index 3 of the array
            }
            catch(Exception ex)
            {
                myException = ex.Message;
                Assert.AreEqual("Error (Get): Invalid index: 3", myException);
            }
        }

        [TestMethod]
        public void TestAddItem()
        {
            //arrange
            ListXwithErrors myList = new ListXwithErrors();

            //act
            myList.Add("a");
            myList.Add("b");
            myList.Add("c");

            //assert
            Assert.AreEqual(3, myList.Length()); //0 because it doesnt increment
        }

        [TestMethod]
        public void TestAddIndexTry()
        {
            string myException;
            try
            {
                //arrange
                ListXwithErrors myList = new ListXwithErrors();

                //act
                myList.Add("a");
                myList.Add("b");
                myList.Add("c");
                myList.Add(1, "second"); //place this at index 1

                //assert
                Assert.AreEqual(0, myList.Length());
                Assert.AreEqual("second", myList.Get(2));
            }
            catch (Exception ex)
            {
                myException = ex.Message;
                Assert.AreEqual("Error (Add): Invalid index: 1", myException); //index 1
            }
        }
        [TestMethod]
        public void TestAddIndex()
        {
            //arrange
            ListXwithErrors myList = new ListXwithErrors();

            //act
            myList.Add(0, "a");
            myList.Add(1, "b");
            myList.Add(2, "c");
            myList.Add(3, "d");
            myList.Add(4, "e");

            //assert
            Assert.AreEqual(5, myList.Length());
            Assert.AreEqual("c", myList.Get(2));
        }

        [TestMethod]
        public void TestGet()
        {
            //arrange
            ListXwithErrors myList = new ListXwithErrors();

            //act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            //assert
            Assert.AreEqual(4, myList.Length());
            Assert.AreEqual(1, myList.Get(0));
        }

        [TestMethod]
        public void TestGetTry()
        {
            string myException;
            try
            {
                //arrange
                ListXwithErrors myList = new ListXwithErrors();

                //act
                myList.Add(1);
                myList.Add(2);
                myList.Add(3);
                myList.Add(4);

                //assert
                Assert.AreEqual(0, myList.Length());
                Assert.AreEqual(1, myList.Get(0));
            }
            catch(Exception ex)
            {
                myException = ex.Message;
                Assert.AreEqual("Error (Get): Invalid index: 0", myException);
            }
        }

        [TestMethod]
        public void TestRemove()
        {
                //arrange
                ListXwithErrors myList = new ListXwithErrors();

                //act
                myList.Add(1);
                myList.Add(2);
                myList.Add(3);

                //myList.Remove(2);

                //assert
                //Assert.AreEqual(3, myList.Length());
                Assert.AreEqual(2, myList.Get(3));
        }
        [TestMethod]
        public void TestRemoveTry()
        {
            string myException;
            try
            {
                //arrage
                ListXwithErrors myList = new ListXwithErrors();

                //act
                myList.Add(1);
                myList.Add(2);
                myList.Add(3);

                //myList.Remove(0);

                //assert
                //Assert.AreEqual(0, myList.Length());
                Assert.AreEqual(3, myList.Get(2));
            }
            catch(Exception ex)
            {
                myException = ex.Message;
                Assert.AreEqual("Error (Remove): Invalid index: 2", myException);
            }
        }
    }
}
