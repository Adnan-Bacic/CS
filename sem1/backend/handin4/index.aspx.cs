using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //for arraylist

namespace handin4
{
    public partial class index : System.Web.UI.Page
    {
        ArrayList ArrayPeople;
        protected void Page_Load(object sender, EventArgs e)
        {
            //typecast
            ArrayPeople = (ArrayList)Application.Get("myArrayPeople");
            if (ArrayPeople == null) ArrayPeople = new ArrayList();
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            //creating person
            Keycard MyCard = new Keycard(Convert.ToInt32(TextBoxKeycard.Text));
            Person p1 = new Person(TextBoxName.Text, Convert.ToInt32(TextBoxAge.Text), TextBoxEmail.Text, MyCard);
            //adding person to arraylist
            ArrayPeople.Add(p1);
            //putting the person into the array
            Application.Set("myArrayPeople", ArrayPeople);

            ListBoxResult.Items.Clear();
            //looping through all
            for (int i = 0; i < ArrayPeople.Count; i++)
            {
                ListBoxResult.Items.Add((ArrayPeople[i]).ToString());
            }
        }

        //save XML
        protected void ButtonSaveXML_Click(object sender, EventArgs e)
        {
            //getting arraylist
            ArrayPeople = (ArrayList)Application.Get("myArrayPeople");
            //if arraylist not null
            if (ArrayPeople != null)
            {
                //save here
                FileUtility.CreateXML(ArrayPeople, Server.MapPath("~/App_Data/person.xml"));
                LabelMessages.Text = "Person saved to xml file";
            }
            else
            {
                LabelMessages.Text = "No person to save";
            }
        }

        protected void ButtonXMLRead_Click(object sender, EventArgs e)
        {
            //read from here
            ArrayPeople = FileUtility.ReadXML(Server.MapPath("~/App_Data/person.xml"));
            Application.Set("myArrayPeople", ArrayPeople);

            ListBoxResult.Items.Clear();
            for (int i = 0; i < ArrayPeople.Count; i++)
            {
                ListBoxResult.Items.Add(ArrayPeople[i].ToString());
            }
            LabelMessages.Text = "XML file read:";
        }

        //handin 5

        protected void ButtonSaveBinary_Click(object sender, EventArgs e)
        {
            //getting array
            ArrayPeople = (ArrayList)Application.Get("myArrayPeople");
            //if array not null
            if (ArrayPeople != null)
            {
                //save here
                FileUtility.WriteBinary(ArrayPeople, Server.MapPath("~/App_Data/people.ser"));
                LabelMessages.Text = "Person saved to binary file";
            }
            else
            {
                LabelMessages.Text = "No people to save";
            }
        }

        protected void ButtonReadBinary_Click(object sender, EventArgs e)
        {
            //read from here
            ArrayPeople = FileUtility.ReadBinary(Server.MapPath("~/App_Data/people.ser"));
            Application.Set("myArrayPeople", ArrayPeople);

            ListBoxResult.Items.Clear();
            for (int i = 0; i < ArrayPeople.Count; i++)
            {
                ListBoxResult.Items.Add(ArrayPeople[i].ToString());
            }
            LabelMessages.Text = "Binary file read";
        }
    }
}