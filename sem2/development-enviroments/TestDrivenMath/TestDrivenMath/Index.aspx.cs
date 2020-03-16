using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestDrivenMath
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Rooter myrooter = new Rooter();
            ListBoxResult.Items.Add("Use of Rooter class");
            ListBoxResult.Items.Add("Squareroot of 2 = " + myrooter.SquareRoot(2));
            ListBoxResult.Items.Add("Squareroot of 0.2 = " + myrooter.SquareRoot(0.2));
            ListBoxResult.Items.Add("Squareroot of 1e-4 = " + myrooter.SquareRoot(1e-4));
            ListBoxResult.Items.Add("Squareroot of 1e6 = " + myrooter.SquareRoot(1e6));
            ListBoxResult.Items.Add("");
            Fibonacci myfibonacci = new Fibonacci();
            ListBoxResult.Items.Add("Use of Fibonacci class");
            ListBoxResult.Items.Add("Fibonacci number 2 = " + myfibonacci.Get(2));
            ListBoxResult.Items.Add("Fibonacci number 5 = " + myfibonacci.Get(5));
            ListBoxResult.Items.Add("Fibonacci number 30 = " + myfibonacci.Get(30));
            ListBoxResult.Items.Add("Fibonacci number 46 = " + myfibonacci.Get(46));
        }
    }
}