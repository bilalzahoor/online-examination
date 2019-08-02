using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace online_examination.Admin.Questions
{
    public partial class Show : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void panel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminPanel.aspx");
        }

        protected void ShowB_Click(object sender, EventArgs e)
        {
            
          /*  con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
            string query = "select * from Question where QuestionType=OS ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();*/
           
            

        }

        protected void subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}