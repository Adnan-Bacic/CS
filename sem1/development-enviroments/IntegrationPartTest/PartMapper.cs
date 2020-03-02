using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace IntegrationPartTest
{
    public class PartMapper
    {
        // get a single part; returns null if not found
        public Part GetPart(int partno, SqlConnection conn)
        {
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string getsql = "select * from part where partno = @partno";
            Part p = null;

            try
            {
                conn.Open();

                cmd = new SqlCommand(getsql, conn);
                cmd.Parameters.Add("@partno", SqlDbType.Int);
                cmd.Parameters["@partno"].Value = partno;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    p = new Part((int)rdr[0], (string)rdr[1], (decimal)rdr[2], (int)rdr[3]);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return p;
        }

        // get all parts; returns empty ArrayList if no parts found
        public ArrayList GetAllParts(SqlConnection conn)
        {
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string getsql = "select * from part";
            Part p = null;
            ArrayList a = new ArrayList();

            try
            {
                conn.Open();

                cmd = new SqlCommand(getsql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    p = new Part((int)rdr[0], (string)rdr[1], (decimal)rdr[2], (int)rdr[3]);
                    a.Add(p);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return a;
        }

        // update one part; returns 1 if found and 0 if not found
        public int UpdatePart(Part p, SqlConnection conn)
        {
            SqlCommand cmd = null;
            string updatesql = "update part set partname = @partname, price = @price, instock = @instock where partno = @partno";
            int rowsupdated = 0;

            try
            {
                conn.Open();

                cmd = new SqlCommand(updatesql, conn);
                cmd.Parameters.Add("@partname", SqlDbType.Text);
                cmd.Parameters.Add("@price", SqlDbType.Decimal);
                cmd.Parameters.Add("@instock", SqlDbType.Int);
                cmd.Parameters.Add("@partno", SqlDbType.Int);

                cmd.Parameters["@partname"].Value = p.partname;
                cmd.Parameters["@price"].Value = p.price;
                cmd.Parameters["@instock"].Value = p.instock;
                cmd.Parameters["@partno"].Value = p.partno;

                rowsupdated = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return rowsupdated;
        }

        // insert a part; returns 1 if inserted and 0 if not inserted
        public int InsertPart(Part p, SqlConnection conn)
        {
            SqlCommand cmd = null;
            string insertsql = "insert into part values(@partno, @partname, @price,  @instock)";
            int rowsupdated = 0;

            try
            {
                conn.Open();

                cmd = new SqlCommand(insertsql, conn);
                cmd.Parameters.Add("@partname", SqlDbType.Text);
                cmd.Parameters.Add("@price", SqlDbType.Decimal);
                cmd.Parameters.Add("@instock", SqlDbType.Int);
                cmd.Parameters.Add("@partno", SqlDbType.Int);

                cmd.Parameters["@partname"].Value = p.partname;
                cmd.Parameters["@price"].Value = p.price;
                cmd.Parameters["@instock"].Value = p.instock;
                cmd.Parameters["@partno"].Value = p.partno;

                rowsupdated = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return rowsupdated;
        }

        // delete a part; returns 1 if deleted and 0 if not deleted
        public int DeletePart(int partno, SqlConnection conn)
        {
            SqlCommand cmd = null;
            string deletesql = "delete from part where partno = @partno";
            int rowsupdated = 0;

            try
            {
                conn.Open();

                cmd = new SqlCommand(deletesql, conn);

                cmd.Parameters.Add("@partno", SqlDbType.Int);

                cmd.Parameters["@partno"].Value = partno;

                rowsupdated = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return rowsupdated;
        }
    }
}