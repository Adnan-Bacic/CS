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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM masterTable";

            try
            {
                conn.Open();

                cmd = new SqlCommand (sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                //SqlDataReader reader = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    LabelLogo.Text = rdr[1].ToString();
                    LabelFooter.Text = rdr[2].ToString();
                    break;
                }
                

                //LabelLogo.DataSource = rdr; //the source of the content
                //LabelLogo.DataBind(); //binds data to the gridview
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