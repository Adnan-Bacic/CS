using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace handin3
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost;
        integrated security = true; database = sem1-handin1");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "select * from dbo.train, dbo.station, dbo.direction, dbo.hour, dbo.hourmin, dbo.minutes, dbo.time, dbo.delay where trainid between 1 and 3 and directionid = 1 and stationid = fk_stationID and fk_directionID = 1 and hourid = 1 and stationid = fkt_stationID and trainid = fkt_trainid and stationid = fkd_stationid order by trainid asc, stationid asc; ";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewTrains.DataSource = rdr; //the source of the content
                GridViewTrains.DataBind(); //binds data to the gridview
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
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = sem1-handin1");
            SqlCommand cmd = null;
            string sqlInsert = "insert into delay (delayID, isDelayed, delayAmount, fkD_stationID) values (@delayID, @isDelayed, @delayAmount, @fkD_stationID)";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlInsert, conn); //get data
                //parameters
                cmd.Parameters.Add("@delayID", SqlDbType.Int);
                cmd.Parameters.Add("@isDelayed", SqlDbType.TinyInt);
                cmd.Parameters.Add("@delayAmount", SqlDbType.Text);
                cmd.Parameters.Add("@fkD_stationID", SqlDbType.Int);

                //where to get the values
                cmd.Parameters["@delayID"].Value = Convert.ToInt32(TextBoxDelayedID.Text);
                cmd.Parameters["@isDelayed"].Value = TextBoxIsDelayed.Text;
                cmd.Parameters["@delayAmount"].Value = TextBoxDelayAmount.Text;
                cmd.Parameters["@fkD_stationID"].Value = Convert.ToInt32(TextBoxFKStationID.Text);

                cmd.ExecuteNonQuery();
                LabelMessages.Text = "Delay has been created";
            }
            catch (Exception ex) //if there are errors
            {
                LabelMessages.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            GetData();
        }
    }
}