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
    }
}