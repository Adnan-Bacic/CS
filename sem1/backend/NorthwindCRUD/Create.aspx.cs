using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace NorthwindCRUD
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UpdateGridView();
            }
        }
        private void UpdateGridView()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost;
        integrated security = true; database = northwind");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "select * from Shippers";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewShippers.DataSource = rdr; //the source of the content
                GridViewShippers.DataBind(); //always databind
            }
            catch (Exception ex) //if there are errors
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
                SqlCommand cmd = null;
                string sqlInsert = "insert into shippers values (@companyname, @phone)";

                try
                {
                    conn.Open();

                    cmd = new SqlCommand(sqlInsert, conn); //get data
                    //there will be 2 parameters
                    cmd.Parameters.Add("@companyname", SqlDbType.Text);
                    cmd.Parameters.Add("@phone", SqlDbType.Text);

                    //where to get the values
                    cmd.Parameters["@companyname"].Value = TextBoxCompany.Text;
                    cmd.Parameters["@phone"].Value = TextBoxPhone.Text;

                    cmd.ExecuteNonQuery();
                    LabelMessages.Text = "Shippers has been inserted";
                }
                catch (Exception ex) //if there are errors
                {
                    LabelMessages.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
        }
    }
}