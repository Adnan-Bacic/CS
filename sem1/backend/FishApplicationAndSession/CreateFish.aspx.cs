using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace FishApplicationAndSession
{
    public partial class CreateFish : System.Web.UI.Page
    {
        ArrayList arrayListForThisPage;
        int userLevel;
        protected void Page_Load(object sender, EventArgs e)
        {
            //browsers can cache pages. a pasible way to avoid login
            //Response.Cache.SetNoStore();
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //always close browsers. else there are problems

            try
            {
                userLevel = (int)Session["level"];
            }
            catch(NullReferenceException nre)
            {
                userLevel = 0;
                Session["level"] = userLevel;
            }
            finally
            {
                SetUpPage();
            }
        }
        private void SetUpPage()
        {
            if (userLevel == 1)
            {
                //ButtonAdd.Enabled = true;
                LabelLevel.Text = "You are logged in and level: " + Session["level"];
            }
            else
            {
                //ButtonAdd.Enabled = false;
                //LabelLevel.Text = "You are not logged in and level: " + Session["level"];
                Response.Redirect("BadGuyPage.aspx");            
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Fish f = new Fish(TextBoxType.Text, Convert.ToDouble(TextBoxLength.Text));
            arrayListForThisPage = (ArrayList)Application["fishCollection"];
            arrayListForThisPage.Add(f);
            //Application["fishCollection"] = arrayListForThisPage;
            //not needed because the reference should not change
            Response.Redirect("index.aspx");
        }
    }
}