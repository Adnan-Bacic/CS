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
    public partial class ReadUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ButtonUpdate.Enabled = false;
            }
            UpdateGridView();
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
            catch(Exception ex) //if there are errors
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void GridViewShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a user clicks on the select, it will show the name and phone
            TextBoxCompany.Text = GridViewShippers.SelectedRow.Cells[2].Text;
            TextBoxPhone.Text = GridViewShippers.SelectedRow.Cells[3].Text;

            //showing it
            LabelMessages.Text = "Your chose ShipperID: " +
            GridViewShippers.SelectedRow.Cells[1].Text;

            ButtonUpdate.Enabled = true;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
            SqlCommand cmd = null;
            string sqlUpdate = "update shippers set companyname = @companyname, phone = @phone where shipperid = @shipperid";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlUpdate, conn); //get data
                //there will be 3 parameters
                cmd.Parameters.Add("@shipperid", SqlDbType.Int);
                cmd.Parameters.Add("@companyname", SqlDbType.Text);
                cmd.Parameters.Add("@phone", SqlDbType.Text);

                //where to get the values
                cmd.Parameters["@shipperid"].Value = Convert.ToInt32(GridViewShippers.SelectedRow.Cells[1].Text);
                cmd.Parameters["@companyname"].Value = TextBoxCompany.Text;
                cmd.Parameters["@phone"].Value = TextBoxPhone.Text;

                cmd.ExecuteNonQuery();
                LabelMessages.Text = "Shippers has been updates";
            }
            catch (Exception ex) //if there are errors
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
                ButtonUpdate.Enabled = false;
            }
            UpdateGridView();
        }
    }
}