using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dogClass
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            owner o1;
            dog d1, d2;
            o1 = new owner("Jill");
            d1 = new dog("Pluto", "Labrador", 81, o1);
            d2 = new dog("Fido", "Poodle", 1, o1);
            ListBoxDog.Items.Add(d1.ToString());
            ListBoxDog.Items.Add(d2.ToString());

            d2.Age = 6;
            d2.Name = "Lady";
            //d2.Type = "Boxer"; - type is read only
            ListBoxDog.Items.Add(d2.ToString());

            d1.Age = 82;
            ListBoxDog.Items.Add(d1.ToString());
        }
    }
}