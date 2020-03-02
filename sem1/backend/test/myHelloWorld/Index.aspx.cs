using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myHelloWorld
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Button text C#";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.Text = "Text box text C#";
        }

        protected void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxInput.Text = "hello world!";
            textBoxEcho.Text = textBoxInput.Text;
        }
    }
}