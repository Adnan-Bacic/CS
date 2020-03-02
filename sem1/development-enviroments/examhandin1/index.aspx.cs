using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examhandin1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //checks if the validation is correct.
        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LabelMessage.Text = "We have recieved your application!";
            }
            else
            {
                LabelMessage.Text = "We have not recieved your application!";
            }
        }
    }
}