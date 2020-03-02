using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IfAndForAndWhile
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool b1 = true;
            bool b2 = false;
            int i1 = 5;
            int i2 = -8;
            int a;

            if (b1)
            {
                ListBoxResult.Items.Add("b1 is true");
            }
            if (b2)
            {
                ListBoxResult.Items.Add("b2 is false");
            }
            if(i1 >= 0)
            {
                ListBoxResult.Items.Add("i1 is 0 or positie");
            }
            if (i2 >= 0)
            {
                ListBoxResult.Items.Add("i2 is 0 or positie");
            }
            else
            {
                ListBoxResult.Items.Add("i2 is negative");
            }
            if(i2 == -3)
            {
                ListBoxResult.Items.Add("i2 is -3");
            }
            if(b1 && b2)
            {
                ListBoxResult.Items.Add("b1 and b2 are both true");
            }
            else
            {
                ListBoxResult.Items.Add("b1 and b2 are not both true");
            }
            if(b1 || b2)
            {
                ListBoxResult.Items.Add("either b1 or b2 are true");
            }
            if (i1 > 0)
            {
                if (i2 > 0)
                {
                    ListBoxResult.Items.Add("i1 and i2 are both positive");
                }
                else
                {
                    ListBoxResult.Items.Add("only i1 is positive");
                }
            }
            else
            {
                ListBoxResult.Items.Add("i1 is negative");
            }

            ListBoxResult.Items.Add("");

            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result = result + i + ' ';
            }
            ListBoxResult.Items.Add(result);
            ListBoxResult.Items.Add("");

            for(int i = 3; i >=0; i--)
            {
                ListBoxResult.Items.Add("" + i);
            }
            for(int i = 1; i <= 10; i++)
            {
                result = "";
                for(int j = 1; j<=10; j++)
                {
                    result = result + i * j + " ";
                }
                ListBoxResult.Items.Add(result);
            }
            ListBoxResult.Items.Add("");

            /* Take a number
             * if even: divide by 2
             * else: multiply by 3 and add 1
             * conteniue untill the result is 1
             * no a found where 1 is not reached
             * no proof is available
             * 
             */
            a = 7;
            result = a + " ";
            while(a != 1)
            {
                if(a % 2 == 0)
                {
                    a = a / 2;
                }
                else
                {
                    a = a * 3 + 1;
                }
                result = result + a + ' ';
            }
            ListBoxResult.Items.Add("we reached 1");
        }
    }
}