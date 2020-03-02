using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace XML_DB
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = horses");
        SqlDataAdapter da = null;
        DataSet ds = null;
        DataTable dt = null;
        SqlCommandBuilder cb = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter();
            ds = new DataSet();
            dt = null;
            cb = new SqlCommandBuilder(da);

            UpdateRepeater();
        }
        private void UpdateRepeater()
        {
            try
            {
                //string to select
                string SQLselect = "select * from horse";
                //use the string with conn
                da.SelectCommand = new SqlCommand(SQLselect, conn);
                //fill the dataset. da opens and closses conn.
                da.Fill(ds, "myHorses");

                //show in repeater
                dt = ds.Tables["myHorses"];

                RepeaterHorse.DataSource = dt;

                //must databind to see
                RepeaterHorse.DataBind();
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

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //where to save file
                ds.WriteXml(Server.MapPath("~/backup/DB_backup.xml"));
                LabelMessages.Text = "Table backup written to XML";
            }
            catch(Exception ex)
            {
                LabelMessages.Text = ex.Message;
            }
        }

        protected void ButtonRead_Click(object sender, EventArgs e)
        {
            //read file from here
            ds.ReadXml(Server.MapPath("~/backup/DB_backup.xml"));
            LabelMessages.Text = "XML added to dataset";

            //there can be duplicate of the primary key
            //the ds is not ok, but the db will be
            //the db will auto increment id
            da.Update(ds, "myHorses");

            //repeater will not show the correct data
            //new data from the db must be read
            ds.Clear();
            UpdateRepeater();
        }
    }
}