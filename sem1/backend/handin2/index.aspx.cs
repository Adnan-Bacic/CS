using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added for arraylist

namespace handin2
{
    public partial class index : System.Web.UI.Page
    {
        //to see the array of users
        static ArrayList arrayTraindrivers;
        static ArrayList arrayAdmins;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string email = "adnan-bacic@hotmail.com";
            string output = "";

            foreach (char c in email)
            {
                output += c;

                LabelMessage.Text = output;
            }


            output = output.Remove(output.LastIndexOf("@") + 1);
            LabelMessage.Text = output;
            output +=  "pig.dk";
            LabelMessage.Text = output;
            



            if (!Page.IsPostBack)
            {
                arrayTraindrivers = new ArrayList();
                arrayAdmins = new ArrayList();
            }
            
            /*
            //creating objects
            Person p1 = new Person("personname", 21, "personemail", 0);
            Traindriver t1 = new Traindriver("traindrivername", 22, "traindriveremail", 1, 1);
            Administator a1 = new Administator("administratorname", 23, "administratorname", 1, 2);


            //where to show
            ListBoxResults.Items.Add(p1.ToString());
            ListBoxResults.Items.Add(t1.ToString());
            ListBoxResults.Items.Add(a1.ToString());
            */
            
        }

        protected void ButtonTrainDriverCreate_Click(object sender, EventArgs e)
        {
            
            if (Page.IsPostBack == true)
            {
                Page.Validate();
                LabelMessage.Text = "Person created!";
            }
            else
            {
                LabelMessage.Text = "Person not created!";
            }
            
            Traindriver t1 = new Traindriver(TrainDriverName.Text,
                Convert.ToInt32(TrainDriverAge.Text),
                TrainDriverEmail.Text, Convert.ToInt32(TrainDriverLicense.Text));
            arrayTraindrivers.Add(t1);
            Session["traindriversCollection"] = arrayTraindrivers;

            ListBoxResults.Items.Clear();
            for (int x = 0; x < arrayAdmins.Count; x++)
            {
                ListBoxResults.Items.Add(((Administator)arrayAdmins[x]).ToString());
            }
        }

        protected void ButtonAdminCreate_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                LabelMessage.Text = "Person created!";
            }
            else
            {
                LabelMessage.Text = "Person not created!";
            }

            Administator a1 = new Administator(AdminName.Text, Convert.ToInt32(AdminAge.Text),
                AdminEmail.Text, Convert.ToInt32(AdminID.Text));
            arrayAdmins.Add(a1);
            Session["adminCollection"] = arrayAdmins;

            ListBoxResults.Items.Clear();
            for (int x = 0; x < arrayAdmins.Count; x++)
            {
                ListBoxResults.Items.Add(((Administator)arrayAdmins[x]).ToString());
            }
        }

        protected void ButtonChangeEmail_Click(object sender, EventArgs e)
        {
            arrayAdmins = (ArrayList)Session["adminCollection"];
            for (int i = 0; i < arrayAdmins.Count; i++)
            {
                if (((Administator)arrayAdmins[i]).AdminID == Convert.ToInt32(AdminID.Text))
                {
                    ((Administator)arrayAdmins[i]).ChangeEmail(AdminEmail.Text);
                    AdminName.Text = ((Administator)arrayAdmins[i]).Email;
                    AdminAge.Text = AdminEmail.Text;
                }
            }
            ListBoxResults.Items.Clear();
            for (int x = 0; x < arrayAdmins.Count; x++)
            {
                ListBoxResults.Items.Add(((Administator)arrayAdmins[x]).ToString());
            }
        }
    }
}