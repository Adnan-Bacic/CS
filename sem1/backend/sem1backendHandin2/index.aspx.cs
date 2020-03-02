using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added

namespace backendHandin2
{
    public partial class index : System.Web.UI.Page
    {
        //to see the array of users
        static ArrayList TrainDriverList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TrainDriverList = new ArrayList();
            }
            /*
            //creating objects
            Person p1 = new Person("personname", 21, "personemail");
            Traindriver t1 = new Traindriver("traindrivername", 22, "traindriveremail", "1");
            Administator a1 = new Administator("administratorname", 23, "administratorname", 1);


            //where to show
            ListBoxResults.Items.Add(p1.ToString());
            ListBoxResults.Items.Add(t1.ToString());
            ListBoxResults.Items.Add(a1.ToString());
            */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Traindriver t1 = new Traindriver(TrainDriverName.Text, Convert.ToInt32(TrainDriverAge.Text), TrainDriverEmail.Text, Convert.ToInt32(TrainDriverLicense.Text));
            ListBoxResults.Items.Add(t1.ToString());

            Session["allTrainDrivers"] = TrainDriverList;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Administator a1 = new Administator(AdminName.Text, Convert.ToInt32(AdminAge.Text), AdminEmail.Text, Convert.ToInt32 ( AdminID.Text));
            ListBoxResults.Items.Add(a1.ToString());
        }
    }
}