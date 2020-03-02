using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moreControls
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DropDownList.Items.Add("Select one");
                DropDownList.Items.Add("first");
                DropDownList.Items.Add("second");
                DropDownList.Items.Add("third");
                DropDownList.AutoPostBack = true;
            }
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList.SelectedIndex > 0)
            {
                LabelMsg.Text = DropDownList.SelectedValue;
            }
        }
    }
}