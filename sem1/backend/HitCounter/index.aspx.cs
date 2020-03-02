using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HitCounter
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count;

            //following code can only be used by 1 browser at a time
            Application.Lock();
            try
            {
                count = (int)Application.Get("hitCounter");
            }
            catch
            {
                count = 0;
            }

            count += + 1;
            Application.Set("hitCounter", count);
            Application.UnLock(); //remember

            LabelNumber.Text = count.ToString();
        }
    }
}