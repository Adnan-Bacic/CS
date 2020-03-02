using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO; //for fileupload

namespace MyFileUpload
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateDropdownList();
            //if a dropdown has to act like a button or selection:
            //DropDownListFiles.AutoPostBack = true;
            //more easy to see in c# code than in the properties
        }

        public void PopulateDropdownList()
        {
            string oldSelection = DropDownListFiles.SelectedValue;

            //clears dropdownlist
            DropDownListFiles.Items.Clear();

            string filename;
            //empty array to get files from this folder
            string[] allMyFiles = Directory.GetFiles(Server.MapPath("~/MyFiles/"));

            //loop through the files
            for (int i = 0; i < allMyFiles.Length; i++)
            {
                filename = new FileInfo(allMyFiles[i]).Name;
                //add the filenames to the dropdown
                DropDownListFiles.Items.Add(filename);

                if (filename == oldSelection) DropDownListFiles.SelectedIndex = i;
            }
        }

        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            //if there is a file
            if (FileUploadMyFile.HasFile)
            {
                //if the name is not empty
                if(TextBoxName.Text != "")
                {
                    //if the first character is not a space
                    if(TextBoxName.Text.Substring(0,1) != " ")
                    {
                        //where to upload files and the name of the file
                        FileUploadMyFile.SaveAs(Server.MapPath("~/MyFiles/") + TextBoxName.Text);
                        TextBoxMessages.Text = "File uploaded";

                        //get file info
                        TextBoxMessages.Text = FileUploadMyFile.PostedFile.FileName + ";" +  FileUploadMyFile.PostedFile.ContentLength.ToString() + ";" + FileUploadMyFile.PostedFile.ContentType.ToString();
                    }
                    else
                    {
                        TextBoxMessages.Text = "Inital space is not allowed";
                    }
                }
                else
                {
                    TextBoxMessages.Text = "New filename is missing";
                }
            }
            else
            {
                TextBoxMessages.Text = "Wrong file";
            }

            //after upload
            PopulateDropdownList();
        }
    }
}