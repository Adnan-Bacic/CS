using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace ExamHandin3_CMS
{
    public partial class EditorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlSelect = "SELECT * FROM items";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlSelect, conn); //get data
                rdr = cmd.ExecuteReader(); //put them in the reader

                GridViewItems.DataSource = rdr; //the source of the content
                GridViewItems.DataBind(); //binds data to the gridview
            }
            catch (Exception e)
            {
                LabelMessages.Text = e.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            string sqlInsert = "INSERT INTO items (itemHeadline, itemCategory, itemDescription, itemImageURL, isHighlighted) VALUES (@itemHeadline, @itemCategory, @itemDescription, @itemImageURL, @isHighlighted)";

            try
            {
                //if there is a file
                if (FileUploadImage.HasFile)
                {
                    //if the name is not empty
                    if (TextBoxHeadline.Text != "")
                    {
                        //if the first character is not a space
                        if (TextBoxHeadline.Text.Substring(0, 1) != " ")
                        {
                            //where to upload files and the name of the file
                            FileUploadImage.SaveAs(Server.MapPath("~/ItemImages/") + TextBoxImageURL.Text);
                            LabelMessages.Text = "File uploaded";

                            //get file info
                            LabelMessages.Text = FileUploadImage.PostedFile.FileName + ";" + FileUploadImage.PostedFile.ContentLength.ToString() + ";" + FileUploadImage.PostedFile.ContentType.ToString();
                        }
                        else
                        {
                            LabelMessages.Text = "Space as the first characters is not allowed";
                        }
                    }
                    else
                    {
                        LabelMessages.Text = "New filename is missing";
                    }
                }
                else
                {
                    LabelMessages.Text = "No file selected";
                }

                conn.Open();

                cmd = new SqlCommand(sqlInsert, conn); //get data
                //parameters
                //cmd.Parameters.Add("@itemID", SqlDbType.Int);
                cmd.Parameters.Add("@itemHeadline", SqlDbType.Text);
                cmd.Parameters.Add("@itemCategory", SqlDbType.Text);
                cmd.Parameters.Add("@itemDescription", SqlDbType.Text);
                cmd.Parameters.Add("@itemImageURL", SqlDbType.Text);
                cmd.Parameters.Add("@isHighlighted", SqlDbType.TinyInt);

                //where to get the values
                //cmd.Parameters["@itemID"].Value = Convert.ToInt32(TextBoxDelayedID.Text);
                cmd.Parameters["@itemHeadline"].Value = TextBoxHeadline.Text;
                cmd.Parameters["@itemCategory"].Value = TextBoxCategory.Text;
                cmd.Parameters["@itemDescription"].Value = TextBoxDescription.Text;
                cmd.Parameters["@itemImageURL"].Value = TextBoxImageURL.Text;
                cmd.Parameters["@isHighlighted"].Value = TextBoxIsHighlighted.Text;

                cmd.ExecuteNonQuery();
                LabelMessages.Text = "New item added";
            }
            catch (Exception e_insert) //if there are errors
            {
                LabelMessages.Text = e_insert.Message;
            }
            finally
            {
                conn.Close();
            }
            GetData();
        }

        protected void ButtonJokeCreate_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true;
            database = webdev-sem2-devEnv-handin3");
                SqlCommand cmd = null;
                string sqlInsert = "INSERT INTO jokes (jokeQuestion, jokeAnswer, fk_id) VALUES (@jokeQuestion, @jokeAnswer, @fk_id)";

                try
                {
                    conn.Open();

                    cmd = new SqlCommand(sqlInsert, conn); //get data
                                                           //parameters
                                                           //cmd.Parameters.Add("@itemID", SqlDbType.Int);
                    cmd.Parameters.Add("@jokeQuestion", SqlDbType.Text);
                    cmd.Parameters.Add("@jokeAnswer", SqlDbType.Text);
                    cmd.Parameters.Add("@fk_id", SqlDbType.Int);

                    //where to get the values
                    //cmd.Parameters["@itemID"].Value = Convert.ToInt32(TextBoxDelayedID.Text);
                    cmd.Parameters["@jokeQuestion"].Value = TextBoxJokeQuestion.Text;
                    cmd.Parameters["@jokeAnswer"].Value = TextBoxJokeAnswer.Text;
                    cmd.Parameters["@fk_id"].Value = TextBoxJokeFKID.Text;

                    cmd.ExecuteNonQuery();
                    LabelMessages.Text = "New joke added";
                }
                catch (Exception e_insert) //if there are errors
                {
                    LabelMessages.Text = e_insert.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //inserting data into textbox when clicking on select in gridview
        protected void GridViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a user clicks on the select, it will show info in textbox
            TextBoxUpdateHighlight.Text = GridViewItems.SelectedRow.Cells[6].Text;

            //showing current info in label
            LabelUpdateInfo.Text = "Your choose item with ID: " +
            GridViewItems.SelectedRow.Cells[1].Text + " and it currently has a highlight value of " +
            GridViewItems.SelectedRow.Cells[6].Text;
        }

        protected void ButtonUpdateHighlight_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = localhost; integrated security = true; database = webdev-sem2-devEnv-handin3");
            SqlCommand cmd = null;
            string sqlUpdate = "update items set isHighlighted = @isHighlighted where itemID = @ItemID";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlUpdate, conn); //get data
                //parameters
                cmd.Parameters.Add("@itemID", SqlDbType.Int);
                cmd.Parameters.Add("@isHighlighted", SqlDbType.TinyInt);

                //where to get the values
                cmd.Parameters["@itemID"].Value = Convert.ToInt32(GridViewItems.SelectedRow.Cells[1].Text);
                cmd.Parameters["@isHighlighted"].Value = Convert.ToInt32(TextBoxUpdateHighlight.Text);

                cmd.ExecuteNonQuery();
                LabelUpdateInfo.Text = "Item has been updated";
            }
            catch (Exception ex) //if there are errors
            {
                LabelUpdateInfo.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}