using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inheritance
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bird b1 = new Bird("Sparrow", "Grey");
            Owl b2 = new Owl("Snow Owl", "White");
            Owl b3 = new Owl("Horned Owl", "Brown", 1);
            Songbird b4 = new Songbird(1, "Nightingald", "Brown");

            //not working
            //bird is not nessecarily a songbird
            //Songbird b5 = new Bird("Blackbird", "Black");

            //songbord is a bird
            //te available methods, properties etc, is those of the bird(not the songbird)
            //the version of the methods are those of the songbird
            Bird b6 = new Songbird(1, "Dodo", "Grey");

            ListBoxResults.Items.Add(b1.ToString());
            ListBoxResults.Items.Add("It is a " + b1.Species);

            //owls
            ListBoxResults.Items.Add(b2.ToString());
            ListBoxResults.Items.Add(b3.ToString());

            //songbird
            ListBoxResults.Items.Add(b4.ToString());

            ListBoxResults.Items.Add("");

            b2.NumberOfMiceCaught = 30;
            ListBoxResults.Items.Add(b2.ToString());

            ListBoxResults.Items.Add("");

            b4.NumberOfSongs = 4;
            ListBoxResults.Items.Add(b4.ToString());

            ListBoxResults.Items.Add("");

            ListBoxResults.Items.Add(b4.OldToString());
            ListBoxResults.Items.Add("The " + b4.Species + " is " + b4.Colour);

            ListBoxResults.Items.Add("");
            ListBoxResults.Items.Add(b6.ToString());
        }
    }
}