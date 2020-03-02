using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added

namespace fishArrayList
{
    public partial class otherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList sessionFish = new ArrayList();
            //sessionFish = (ArrayList)Session["fishArrayList"];

            if(Session["fishCollection"] == null)
            {
                ListBoxOther.Items.Add("Empty");
            }
            else
            {
                sessionFish = (ArrayList)Session["fishCollection"];
                ListBoxOther.Items.Clear();
                for (int i = 0; i < sessionFish.Count; i++)
                {
                    ListBoxOther.Items.Add(sessionFish[i].ToString());
                }
            }

            
        }

        protected void ButtonGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}