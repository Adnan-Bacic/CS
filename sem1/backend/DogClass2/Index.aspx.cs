using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DogClass
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Owner o1;
            Dog d1, d2;
            o1 = new Owner("Jill");
            d1 = new Dog("Pluto", "labrador", 81, o1);
            d2 = new Dog("Fido", "poodle", 1, o1);
            ListBoxDog.Items.Add(d1.ToString());
            ListBoxDog.Items.Add(d2.ToString());
            d2.Age = 6;
            d2.Name = "Lady";
            // d2.Type = "boxer";       Type is a read only
            ListBoxDog.Items.Add(d2.ToString());
            d1.Age = 82;
            ListBoxDog.Items.Add(d1.ToString());
        }
    }
}