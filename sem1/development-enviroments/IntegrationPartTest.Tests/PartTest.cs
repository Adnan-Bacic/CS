using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace IntegrationPartTest.Tests
{
    [TestClass]
    public class PartTest
    {
        // Do not use original database
        SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = TestPartDB");

        public void SetupDB()
        {
            SqlCommand cmd = null;
            string setupsql = @"
            begin try drop table Part end try begin catch end catch
            create table Part
            (
                Partno      int             primary key,
                Partname    nvarchar(50)    not null,
                Price       decimal(10,2)   not null,
                Instock     int             not null
            );
            insert into Part
            values  (1, 'Part A', 25.25, 200),
                    (2, 'Part B', 3.5, 8),
                    (3, 'Part C', 6, 17)
            ";

            try
            {
                conn.Open();
                cmd = new SqlCommand(setupsql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                //stop the test if it fails
                Assert.Fail();
            }
            finally
            {
                //close connection
                conn.Close();
            }
        }

        private void TearDown()
        {
            SqlCommand cmd = null;
            //if its there drop it
            string teardownsql = @"
            begin try drop table Part end try begin catch end catch
            ";
            //open sql connection
            conn.Open();
            cmd = new SqlCommand(teardownsql, conn);
            cmd.ExecuteNonQuery();
        }

        // get a part that exist
        [TestMethod]
        public void TestGetPartOK()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = pm.GetPart(2, conn);
            TearDown();

            // assert
            Assert.AreEqual(2, p.partno);
        }

        //get a part that does not exist
        [TestMethod]
        public void TestGetPartFail()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = pm.GetPart(4, conn);
            TearDown();

            // assert
            Assert.AreEqual(null, p);
        }

        //get all parts
        [TestMethod]
        public void TestGetAllOK()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            ArrayList a = pm.GetAllParts(conn);
            TearDown();

            // assert
            Assert.AreEqual(3, a.Count);
        }

        //get all parts from empty database
        [TestMethod]
        public void TestGetAllEmpty()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            pm.DeletePart(1, conn);
            pm.DeletePart(2, conn);
            pm.DeletePart(3, conn);
            ArrayList a = pm.GetAllParts(conn);
            TearDown();

            // assert
            Assert.AreEqual(0, a.Count);
        }

        // update a part that exist
        [TestMethod]
        public void TestUpdatePartOK()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = pm.GetPart(2, conn);
            p.price = 1000.50m;
            int rowsupdated = pm.UpdatePart(p, conn);
            Part newpart = pm.GetPart(2, conn);
            TearDown();

            // assert
            Assert.AreEqual(1, rowsupdated);
            Assert.AreEqual(1000.50m, newpart.price);
        }

        // update a part that does not exist
        [TestMethod]
        public void TestUpdatePartFail()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = pm.GetPart(2, conn);
            p.partno = 4;
            int rowsupdated = pm.UpdatePart(p, conn);
            TearDown();

            // assert
            Assert.AreEqual(0, rowsupdated);
        }
        // create a part
        [TestMethod]
        public void TestCreatePartOK()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = new Part(4, "Part D", 34.6m, 25);
            int rowsinserted = pm.InsertPart(p, conn);
            Part pnew = pm.GetPart(4, conn);
            TearDown();

            // assert
            Assert.AreEqual(1, rowsinserted);
            Assert.AreEqual("Part D", pnew.partname);
        }
        // create a part with duplicate primary key
        [TestMethod]
        public void TestCreatePartFail()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            Part p = new Part(2, "Part D", 34.6m, 25);
            int rowsinserted = pm.InsertPart(p, conn);
            TearDown();

            // assert
            Assert.AreEqual(0, rowsinserted);
            Assert.AreEqual("Part D", p.partname);
        }
        // delete a part
        [TestMethod]
        public void TestDeletePart()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            int rowdeleted = pm.DeletePart(2, conn);
            Part p = pm.GetPart(2, conn);
            TearDown();

            // assert
            Assert.AreEqual(1, rowdeleted);
            Assert.AreEqual(null, p);
        }
        // delete a part which doesnt exist
        [TestMethod]
        public void TestDeletePartFail()
        {
            // arrange
            SetupDB();

            // act
            PartMapper pm = new PartMapper();
            int rowdeleted = pm.DeletePart(4, conn);
            ArrayList a = pm.GetAllParts(conn);
            TearDown();

            // assert
            Assert.AreEqual(0, rowdeleted);
            Assert.AreEqual(3, a.Count);
        }
    }
}
