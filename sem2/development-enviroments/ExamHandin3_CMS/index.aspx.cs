using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace ExamHandin3_CMS
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
            GetHighlightedData();
            GetItemAndJoke();
            GetJokes();
        }

        private void GetData()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM items";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewItems.DataSource = rdr; //the source of the content
                GridViewItems.DataBind(); //binds data to the gridview
            }
            catch(Exception e)
            {
                LabelMessages.Text = e.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetHighlightedData()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM items WHERE isHighlighted = 1";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewHighlight.DataSource = rdr; //the source of the content
                GridViewHighlight.DataBind(); //binds data to the gridview
            }
            catch (Exception e)
            {
                LabelMessages.Text = e.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void GetItemAndJoke()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM items, jokes WHERE itemID = fk_id";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewMatch.DataSource = rdr; //the source of the content
                GridViewMatch.DataBind(); //binds data to the gridview
            }
            catch (Exception e)
            {
                LabelMessages.Text = e.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetJokes()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM jokes";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewJokes.DataSource = rdr; //the source of the content
                GridViewJokes.DataBind(); //binds data to the gridview
            }
            catch (Exception e)
            {
                LabelMessages.Text = e.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}