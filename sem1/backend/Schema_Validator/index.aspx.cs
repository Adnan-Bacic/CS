using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;
using System.Xml.Schema;

namespace Schema_Validator
{
    public partial class index : System.Web.UI.Page
    {
        private bool errorsOnPage;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonValidate_Click(object sender, EventArgs e)
        {
            errorsOnPage = false;
            ListBoxErrors.Items.Clear();

            //creating the xml reader
            XmlReaderSettings settings = new XmlReaderSettings();
            //add schema to settings
            settings.Schemas.Add(null, Server.MapPath(TextBoxXSD.Text));
            //the xml file has a DTD file which must be ignore
            settings.DtdProcessing = DtdProcessing.Ignore;

            //validation type
            settings.ValidationType = ValidationType.Schema;

            //if a method is used as parameters it is called a delegate
            settings.ValidationEventHandler += new ValidationEventHandler(MyHandler);

            //creates the xml reader
            XmlReader reader = XmlReader.Create(Server.MapPath(TextBoxXML.Text), settings);

            //read xml into document
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();

            ListBoxErrors.Items.Add("");
            ListBoxErrors.Items.Add("The XMLDocument can be validated at any time");
            ListBoxErrors.Items.Add("");

            doc.Validate(MyHandler);

            //if errors
            if (!errorsOnPage)
            {
                LabelMesssages.Text = "XML ok";
            }
            else
            {
                LabelMesssages.Text = "One or more errors in XML";
            }
        }
        //if there are errors
        public void MyHandler(object sender, ValidationEventArgs e)
        {
            errorsOnPage = true;
            ListBoxErrors.Items.Add(e.Severity + " : " + e.Message);
        }
    }
}