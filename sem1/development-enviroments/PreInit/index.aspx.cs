using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PreInit
{
    public partial class index : System.Web.UI.Page
    {
        //preinit: before the page is initialized
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.Theme = "themeDomestic";
            }
            else
            {
                Page.Theme = Server.HtmlEncode(Request.QueryString["Theme"]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDomestic_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEgypt_Click(object sender, EventArgs e)
        {

        }
    }
}