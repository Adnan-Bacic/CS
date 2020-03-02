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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UpdateGridView();
                ButtonDelete.Enabled = false;
            }
            DropDownListShippers.AutoPostBack = true;
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

                rdr.Close();
                rdr = cmd.ExecuteReader();

                DropDownListShippers.DataSource = rdr;
                DropDownListShippers.DataTextField = "companyname";
                DropDownListShippers.DataValueField = "shipperid";
                DropDownListShippers.DataBind();
                DropDownListShippers.Items.Insert(0, "Select a shipper");
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



        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = northwind");
            SqlCommand cmd = null;
            string sqlInsert = "delete from shippers where shipperid = @shipperid";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlInsert, conn); //get data
                cmd.Parameters.Add("@shipperid", SqlDbType.Int);

                cmd.Parameters["@shipperid"].Value = Convert.ToInt32(DropDownListShippers.SelectedValue);

                cmd.ExecuteNonQuery();
                LabelMessages.Text = "Shipper " + DropDownListShippers.SelectedValue + "deleted";
            }
            catch (Exception ex) //if there are errors
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
                UpdateGridView();
            }
        }

        protected void DropDownListShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListShippers.SelectedIndex != 0)
            {
                LabelMessages.Text = "Your chose shipper: " + DropDownListShippers.SelectedValue;
                ButtonDelete.Enabled = true;
            }
            else
            {
                LabelMessages.Text = "You chose none";
                ButtonDelete.Enabled = false;
            }
        }
    }
}