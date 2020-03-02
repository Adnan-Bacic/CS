using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //added

namespace fishArrayList
{
    public partial class index : System.Web.UI.Page
    {
         static ArrayList fishArrayList;
        //static: belongs to the page class, not to the object
        //static fishArrayList = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                fishArrayList = new ArrayList();
            }

        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Fish f = new Fish(TextBoxType.Text, Convert.ToInt32(TextBoxLength.Text));
            fishArrayList.Add(f);

            //session can be used for data to be used on different pages
            Session["FishCollection"] = fishArrayList;
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            ListBoxFish.Items.Clear();
            for(int i = 0; i < fishArrayList.Count; i++)
            {
                ListBoxFish.Items.Add(fishArrayList[i].ToString());
            }
        }
    }
}