using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections; //for arraylist

namespace Serialization
{
    public partial class index : System.Web.UI.Page
    {
        //arraylist
        ArrayList catList;

        protected void Page_Load(object sender, EventArgs e)
        {
            //typecast
            catList = (ArrayList)Application.Get("mycatList");
            if (catList == null) catList = new ArrayList();
        }

        //for creating a new item
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            //new chip
            Chip cc = new Chip(Convert.ToInt32(TextBoxID.Text));
            //new cat
            Cat c = new Cat(TextBoxName.Text, TextBoxColour.Text, cc);
            //adding cats to arraylist
            catList.Add(c);
            //putting the catlist into the array
            Application.Set("mycatList", catList);

            ListBoxCats.Items.Clear();
            for(int i=0; i < catList.Count; i++)
            {
                ListBoxCats.Items.Add(catList[i].ToString());
            }
            //clearing textboxes
            TextBoxName.Text = "";
            TextBoxColour.Text = "";
            TextBoxID.Text = "";
            LabelMessages.Text = "New cat added";
        }

        //saving as binary
        protected void ButtonSaveBinary_Click(object sender, EventArgs e)
        {
            //getting catlist
            catList = (ArrayList)Application.Get("mycatList");
            //if catlist not null
            if(catList != null)
            {
                //save here
                FileUtility.WriteFile(catList, Server.MapPath("~/App_Data/Catfile.ser"));
                LabelMessages.Text = "Cat saved to binary file";
            }
            else
            {
                LabelMessages.Text = "No cats to save";
            }
        }
        //reading binary
        protected void ButtonReadBinary_Click(object sender, EventArgs e)
        {
            //read from here
            catList = FileUtility.ReadFile(Server.MapPath("~/App_Data/Catfile.ser"));
            Application.Set("mycatList", catList);

            ListBoxCats.Items.Clear();
            ListBoxCats.Items.Add("Cats read from binary file");
            for (int i = 0; i < catList.Count; i++)
            {
                ListBoxCats.Items.Add(catList[i].ToString());
            }
            LabelMessages.Text = "Cat file read";
        }

        //saving as xml
        protected void ButtonSaveXML_Click(object sender, EventArgs e)
        {
            //getting catlist
            catList = (ArrayList)Application.Get("mycatList");
            //if catlist not null
            if (catList != null)
            {
                //save here
                FileUtility.WriteCatXML(catList, Server.MapPath("~/App_Data/Catfile.xml"));
                //ListBoxCats.Items.Clear();
                LabelMessages.Text = "Cat saved to xml file";
            }
            else
            {
                LabelMessages.Text = "No cats to save";
            }
        }

        //reading xml
        protected void ButtonReadXML_Click(object sender, EventArgs e)
        {
            //read from here
            catList = FileUtility.ReadCatXML(Server.MapPath("~/App_Data/Catfile.xml"));
            Application.Set("mycatList", catList);

            ListBoxCats.Items.Clear();
            ListBoxCats.Items.Add("Cats read from XML file");
            for (int i = 0; i < catList.Count; i++)
            {
                ListBoxCats.Items.Add(catList[i].ToString());
            }
            LabelMessages.Text = "Cat file read";
        }

        //save old school json
        protected void ButtonSaveJSONOldSchool_Click(object sender, EventArgs e)
        {
            //getting catlist
            catList = (ArrayList)Application.Get("mycatList");
            //if catlist not null
            if (catList != null)
            {
                //save here
                FileUtility.WriteJSONOldSchool(catList, Server.MapPath("~/App_Data/CatfileOldSchool.txt"));
                //ListBoxCats.Items.Clear();
                LabelMessages.Text = "Cat saved to old school json file";
            }
            else
            {
                LabelMessages.Text = "No cats to save";
            }
        }

        //read old school json
        protected void ButtonReadJSONOldSchool_Click(object sender, EventArgs e)
        {
            //read from here
            catList = FileUtility.ReadJSONOldSchool(Server.MapPath("~/App_Data/CatfileOldSchool.txt"));
            Application.Set("mycatList", catList);

            ListBoxCats.Items.Clear();
            ListBoxCats.Items.Add("Cats read from JSON old school file");
            for (int i = 0; i < catList.Count; i++)
            {
                ListBoxCats.Items.Add(catList[i].ToString());
            }
            LabelMessages.Text = "Cat file read from JSON old school file";
        }

        //save json
        protected void ButtonSaveJSON_Click(object sender, EventArgs e)
        {
            //getting catlist
            catList = (ArrayList)Application.Get("mycatList");
            //if catlist not null
            if (catList != null)
            {
                //list is an object
                List<Cat> ListOfCats = catList.Cast<Cat>().ToList();
                //save here
                FileUtility.WriteJSON(ListOfCats, Server.MapPath("~/App_Data/CatJSON.txt"));
                //ListBoxCats.Items.Clear();
                LabelMessages.Text = "Cat saved to json file";
            }
            else
            {
                LabelMessages.Text = "No cats to save";
            }
        }

        //read json
        protected void ButtonReadJSON_Click(object sender, EventArgs e)
        {
            //read from here
            //list is an object
            List<Cat> ListOfCats = FileUtility.ReadJSON(Server.MapPath("~/App_Data/CatJSON.txt"));
            //convert object to arraylist
            ArrayList catList = new ArrayList(ListOfCats);
            Application.Set("mycatList", catList);

            ListBoxCats.Items.Clear();
            ListBoxCats.Items.Add("Cats read from JSON file");
            for (int i = 0; i < catList.Count; i++)
            {
                ListBoxCats.Items.Add(catList[i].ToString());
            }
            LabelMessages.Text = "Cat file read from JSON file";
        }
    }
}