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
    public partial class repeater : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = localhost;
        integrated security = true; database = catDB");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string sqlSelect = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMessages.Text = "No error messages";

            RepeaterCats.DataBind();
        }

        public void showData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn);
                rdr = cmd.ExecuteReader();
                RepeaterCats.DataSource = rdr;
                RepeaterCats.DataBind();
            }
            catch (Exception ex)
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonShowCats_Click(object sender, EventArgs e)
        {
            sqlSelect = "select top 10 * from cat";
            showData();
        }
    }
}