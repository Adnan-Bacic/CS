using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added for arraylist

namespace handin2
{
    public partial class SeeUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //array for traindrivers
            ArrayList sessionTraindrivers = new ArrayList();
            sessionTraindrivers = (ArrayList)Session["traindriversCollection"];

            //array for admins
            ArrayList sessionAdmins = new ArrayList();
            sessionAdmins = (ArrayList)Session["adminCollection"];

            //traindrivers list
            if (Session["traindriversCollection"] == null)
            {
                ListBoxTrainDrivers.Items.Add("No trainsdrivers");
            }
            else
            {
                ListBoxTrainDrivers.Items.Clear();
                for (int i = 0; i < sessionTraindrivers.Count; i++)
                {
                     ListBoxTrainDrivers.Items.Add(sessionTraindrivers[i].ToString());
                }
            }
            //admins list
            if (Session["adminCollection"] == null)
            {
                ListBoxAdmins.Items.Add("No administrators");
            }
            else
            {
                ListBoxAdmins.Items.Clear();
                for (int i = 0; i < sessionAdmins.Count; i++)
                {
                    ListBoxAdmins.Items.Add(sessionAdmins[i].ToString());
                }
            }
        }
    }
}