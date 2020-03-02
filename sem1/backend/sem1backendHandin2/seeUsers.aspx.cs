using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added

namespace backendHandin2
{
    public partial class SeeUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList TrainDriverList = new ArrayList();

            if (Session["allTrainDrivers"] == null)
            {
                ListBoxUsers.Items.Add("Empty");
            }
            else
            {
                TrainDriverList = (ArrayList)Session["allTrainDrivers"];
                ListBoxUsers.Items.Clear();
                for (int i = 0; i < TrainDriverList.Count; i++)
                {
                    ListBoxUsers.Items.Add(TrainDriverList[i].ToString());
                }
            }
        }
    }
}