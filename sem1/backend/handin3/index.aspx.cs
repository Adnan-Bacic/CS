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
    public partial class index : System.Web.UI.Page
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
    }
}