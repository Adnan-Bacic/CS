using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace DB_Connection
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = localhost;
        integrated security = true; database = northwind");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string sqlSelect = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessage.Text = "No error messages";

            GridViewNorthwind.DataBind();
            ListBoxNorthwind.Items.Clear();
        }

        public void showData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn);
                rdr = cmd.ExecuteReader();
                GridViewNorthwind.DataSource = rdr;
                GridViewNorthwind.DataBind();
            }
            catch(Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            sqlSelect = "select top 10 * from products";
            showData();
        }

        protected void ButtonListbox_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sqlSelect = "select top 10 * from products";
                cmd = new SqlCommand(sqlSelect, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListBoxNorthwind.Items.Add("Product name = " + rdr[1] + ", Category: " + rdr["categoryid"]);
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}