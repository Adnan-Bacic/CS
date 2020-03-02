using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionExamples
{
    public partial class index : System.Web.UI.Page
    {
        private int a, b, c, result;
        private int? aa, bb, cc, resultresult; //? means that maybe it has a value
        protected void Page_Load(object sender, EventArgs e)
        {
            a = 2;
            b = 0;

            aa = 2;
            bb = null;

            //1
            try
            {
                ListBoxResults.Items.Add("1");
                c = Div1(a, b);
                ListBoxResults.Items.Add(a + "/" + b + "=" + c);
                ListBoxResults.Items.Add("");
            }
            catch (DivideByZeroException dbze)
            {
                ListBoxResults.Items.Add(dbze.Message);
                ListBoxResults.Items.Add("");
            }

            //2
            try
            {
                ListBoxResults.Items.Add("2");
                c = Div2(a, b);
                ListBoxResults.Items.Add(a + "/" + b + "=" + c);
                ListBoxResults.Items.Add("");
            }
            catch(DivideByZeroException dbze)
            {
                ListBoxResults.Items.Add(dbze.Message);
                ListBoxResults.Items.Add("");
            }

            //3
            try
            {
                ListBoxResults.Items.Add("3");
                c = Div3(a, b);
                ListBoxResults.Items.Add(a + "/" + b + "=" + c);
                ListBoxResults.Items.Add("");
            }
            catch (MyZeroDivideException mzde)
            {
                ListBoxResults.Items.Add(mzde.Message + ". " + mzde.ShowAdvice());
                ListBoxResults.Items.Add("");
            }
            catch (Exception ex)
            {
                ListBoxResults.Items.Add("An exception occured : " + ex.Message);
            }

            //4
            ListBoxResults.Items.Add("4");
            cc = Div4(aa, bb);
            try
            {
                ListBoxResults.Items.Add(aa.Value + " / " + bb.Value + " = " + cc);
            }
            catch(InvalidOperationException ioe)
            {
                ListBoxResults.Items.Add(ioe.Message + " a nullble variable had the value of null");
            }
            finally
            {
                ListBoxResults.Items.Add(aa + " / " + bb + " = " + cc);
            }
        }

        //divide method 1
        public int Div1(int a, int b)
        {
            result = a / b;
            return result;
        }

        //divide method 2
        public int Div2(int a, int b)
        {
            try
            {
                result = a / b;
                return result;
            }
            catch(DivideByZeroException dbze)
            {
                ListBoxResults.Items.Add(dbze.Message + " : divisor changed to 1");
                result = a / 1;
                return result;
            }
        }

        //divide method 3
        public int Div3(int a, int b)
        {
            if (b == 0) throw new MyZeroDivideException("Divisor is 0", "A divisor =0 is not allowed");
            else
            {
                result = a / b;
                return result;
            }
        }

        //divide method 4
        public int? Div4(int? aa, int? bb)
        {
            resultresult = aa / bb;
            return resultresult;
        }
    }
}