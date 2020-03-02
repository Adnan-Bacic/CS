using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//must have
using System.Data;
using System.Data.SqlClient;

namespace XML_CRUD
{
    public partial class index : System.Web.UI.Page
    {
        DataSet ds;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UpdatePage();
            }
            else
            {
                //if we pick a cat. that means their selected index is 1 or more since 0 is our custom text
                if(DropDownListCats.SelectedIndex != 0)
                {
                    //gets xml
                    ds = new DataSet();
                    ds.ReadXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
                    dt = ds.Tables["Cat"];

                    //loop
                    foreach (DataRow row in dt.Select("CatID =" + Convert.ToInt32(DropDownListCats.SelectedValue)))
                    {
                        TextBoxID.Text = row["CatID"].ToString();
                        TextBoxName.Text = row["CatName"].ToString();
                        TextBoxColour.Text = row["CatColour"].ToString();
                        TextBoxPicture.Text = row["Picture"].ToString();
                    }
                    LabelMessages.Text = TextBoxName.Text + " has been selected";
                    //selectedindex must be set to 0 to avoid old data to be read at postback
                    DropDownListCats.SelectedIndex = 0;

                    //when selecting a cat disable create
                    ButtonCreate.Enabled = false;
                    ButtonUpdate.Enabled = true;
                    ButtonDelete.Enabled = true;
                }
            }
            
        }

        private void UpdatePage()
        {
            //when we make a change in the dropdownlist it goes back to the server
            DropDownListCats.AutoPostBack = true;
            DropDownListCats.Items.Clear();

            try
            {
                //reading xml file
                ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
                //when we have the data, get datatable 1 by 1
                dt = ds.Tables["Cat"];//"Cat" is the name of the table for each cat

                //where the dropdownlist should get the data
                DropDownListCats.DataSource = dt;
                //what will we show in the dropdown. [1] is the row with names
                DropDownListCats.DataTextField = dt.Columns[1].ToString();
                //we show the name, but we want to work with the id so we want the value, which is [0]
                DropDownListCats.DataValueField = dt.Columns[0].ToString();
                //bind data
                DropDownListCats.DataBind();
            }
            catch
            {
                //if the xml file doesnt exist or it is empty: dt made only to display of headings
                MakeNewDSandDT();
            }
            finally
            {
                //bind data
                RepeaterCat.DataSource = dt;
                RepeaterCat.DataBind();

                //text at the start of the dropdown
                DropDownListCats.Items.Insert(0, "Select a cat");
            }
            //clearing textboxes
            TextBoxID.Text = "";
            TextBoxName.Text = "";
            TextBoxColour.Text = "";
            TextBoxPicture.Text = "";
            //setting buttons to be disabled or enabled
            ButtonCreate.Enabled = true;
            ButtonUpdate.Enabled = false;
            ButtonDelete.Enabled = false;
        }
        private void MakeNewDSandDT()
        {
            //"Cats" is the root name of the xml file. "Cat" is the name of the element around cats
            ds = new DataSet("Cats");
            dt = ds.Tables.Add("Cat");
            //populating the xml file
            dt.Columns.Add("CatID", typeof(Int32));
            dt.Columns.Add("CatName", typeof(string));
            dt.Columns.Add("CatColour", typeof(string));
            dt.Columns.Add("Picture", typeof(string));
        }

        //create new cat
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
                //when we have the data, get datatable 1 by 1
                dt = ds.Tables["Cat"];//"Cat" is the name of the table for each cat
            }
            catch
            {
                //xml file does not exist
                MakeNewDSandDT();
            }

            //we need to loop through the cats to make sure the id are unique when creating a new cat
            int maxCatID = 0;
            if(dt == null)
            {
                //xml file exists but is empty
                MakeNewDSandDT();
            }
            else
            {
                foreach(DataRow row in dt.Rows)
                {
                    //loops through all the catid to see the highest
    if (Convert.ToInt32(row["CatID"].ToString()) > maxCatID) maxCatID = Convert.ToInt32(row["CatID"].ToString());
                }
                //creating new cat
                DataRow newRow = dt.NewRow();
                newRow["CatID"] = maxCatID + 1;
                newRow["CatName"] = TextBoxName.Text;
                newRow["CatColour"] = TextBoxColour.Text;
                newRow["Picture"] = TextBoxPicture.Text;

                //adding our new row the to datatable
                dt.Rows.Add(newRow);

                //create xml
                ds.WriteXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
                LabelMessages.Text = TextBoxName.Text + " has been created with id= " + (maxCatID + 1);

                UpdatePage();
            }
        }

        //update cat
        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
            dt = ds.Tables["Cat"];

            //loop
            foreach(DataRow row in dt.Select("CatID =" + Convert.ToInt32(TextBoxID.Text)))
            {
                //updating each row
                row["CatID"] = Convert.ToInt32(TextBoxID.Text);
                row["CatName"] = TextBoxName.Text;
                row["CatColour"] = TextBoxColour.Text;
                row["Picture"] = TextBoxPicture.Text;
            }
            ds.WriteXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
            LabelMessages.Text = TextBoxName.Text + " has been updated";

            UpdatePage();
        }

        //delete cat
        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
            dt = ds.Tables["Cat"];

            //loop
            foreach (DataRow row in dt.Select("CatID =" + Convert.ToInt32(TextBoxID.Text)))
            {
                //deleting each row
                row.Delete();
            }
            ds.WriteXml(Server.MapPath("~/xml_file/Cat_XML.xml"));
            LabelMessages.Text = TextBoxName.Text + " has been deleted";

            UpdatePage();
        }

        //cancel button
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            LabelMessages.Text = "Input fields have been cleared";
            UpdatePage();
        }
    }
}