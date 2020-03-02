using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace personClass
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //age
            persons p1, p2, p3;
            p1 = new persons(20);
            p2 = new persons(40);

            //talk
            ListBoxTalk.Items.Add(p1.talk());
            ListBoxTalk.Items.Add(p2.talk());

            //testing
            p3 = p2;
            ListBoxTalk.Items.Add(p3.talk());
            p3 = p1;
            ListBoxTalk.Items.Add(p3.talk());
            p1 = p2;
            ListBoxTalk.Items.Add(p1.talk());
        }
    }
}