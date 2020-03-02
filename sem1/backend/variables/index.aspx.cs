using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace variables
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i1, i2, i3;
            double d1, d2, d3;
            bool b1, b2;
            char c1;
            string s1, s2;
            string myspace = "\u00a0";

            i1 = 1;
            i2 = 2;
            i3 = i1 + i2;
            ListBoxResult.Items.Add(i1 + " + " + i2 + " = " + i3);
            ListBoxResult.Items.Add("i1 is " + i1);
            i1 = i1 + 1;
            ListBoxResult.Items.Add("i1 is now " + i1);
            i1++;
            ListBoxResult.Items.Add("i1 is now " + i1);
            i1 = 3 % i2;
            ListBoxResult.Items.Add("i1 is now the remainder of 3/2" + i1);

            d1 = 355.00;
            d2 = 113;
            d3 = d1 / d2;
            ListBoxResult.Items.Add("d3 is " + d3);

            b1 = true;
            b2 = false;
            ListBoxResult.Items.Add("b1 is " + b1 + "and b2 is " + b2);

            c1 = '!'; //Must be single quotes
            ListBoxResult.Items.Add("c1 is " + c1);

            s1 = "hello";
            s2 = "world";
            ListBoxResult.Items.Add(s1 + myspace + s2);
            ListBoxResult.Items.Add(s1 + myspace + s2 + myspace + c1);
        }
    }
}