using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added for arraylist

namespace FishApplicationAndSession
{
    public partial class index : System.Web.UI.Page
    {
        ArrayList fishArrayList;
        int userLevel; //1 for logged in, 0 logged out
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userLevel = (int)Session["level"];
            }
            catch (NullReferenceException nre)
            {
                userLevel = 0;
                Session["level"] = userLevel;
            }
            finally //in any case
            {
                TextBoxPassword.TextMode = TextBoxMode.Password; //makes the passwords dots
                SetUpPage();
            }

            if(Application["fishCollection"] == null)
            {
                fishArrayList = new ArrayList();
                Application["fishCollection"] = fishArrayList;
            }
            fishArrayList = (ArrayList)Application["fishCollection"];
            if(fishArrayList.Count == 0)
            {
                TextBoxFish.Text = "No fish";
            }
            else
            {
                TextBoxFish.Text = "";
                for (int i = 0; i < fishArrayList.Count; i++)
                {
                    TextBoxFish.Text = TextBoxFish.Text + fishArrayList[i].ToString() + "\n";
                }
            }
        }
        private void SetUpPage()
        {
            if(userLevel == 1)
            {
                ButtonAdd.Enabled = true;
                LabelLevel.Text = "You are logged in and level: " + Session["level"];
            }
            else
            {
                ButtonAdd.Enabled = false;
                LabelLevel.Text = "You are not logged in and level: " + Session["level"];
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "123")
            {
                userLevel = 1;
            }
            else
            {
                userLevel = 0;
            }
            Session["level"] = userLevel;
            SetUpPage();
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            userLevel = 0;
            Session["level"] = userLevel;
            SetUpPage();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateFish.aspx");
        }
    }
}