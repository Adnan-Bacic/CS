using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObjectExample
{
    public partial class index : System.Web.UI.Page
    {
        private Car acar;
        private Car bcar;
        protected void Page_Load(object sender, EventArgs e)
        {
            acar = new Car("Ferrari", 2015);
            ListBoxResults.Items.Add("a car: " + acar.ToString());

            bcar = acar;
            ListBoxResults.Items.Add("b car: " + bcar.ToString());

            bcar.type = "Nasserati";
            bcar.year = 2001;
            ListBoxResults.Items.Add("b car: " + bcar.ToString());

            //a now has the data of b
            ListBoxResults.Items.Add("a: " + acar.ToString());
            ListBoxResults.Items.Add("b: " + bcar.ToString());
        }
    }
}