using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        //cannot work on page load
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LabelMessage.Text = "Valid page";
            }
            else
            {
                LabelMessage.Text = "Invalid page";
            }
        }
    }
}