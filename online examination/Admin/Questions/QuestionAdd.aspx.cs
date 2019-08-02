using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.Admin.Questions
{
    public partial class QuestionAdd : System.Web.UI.Page
    {
        SqlConnection con;



        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
     
           
        }

        protected void qsubmit_Click(object sender, EventArgs e)
        {
            string query = "insert into Question values('" + subject.SelectedValue + qno.Text + "','" + qno.Text + "','" + question.Text + "','" + subject.Text + "','" + Key.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            string query1 = "insert into QuestionOptions values('" + subject.SelectedValue + qno.Text + "','" + A.Text + "','" + B.Text + "','" + C.Text + "','" + D.Text + "')";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            int result=cmd1.ExecuteNonQuery();
            if (result == 1)
            {
                Response.Write("<script>alert('Question Added!');</script>");
                clearFields();
            }
            else {
                Response.Write("<script>alert('Error!');</script>");
            }
        }
        void clearFields() {
            qno.Text = "";
            question.Text = "";
            A.Text = "";
            B.Text = "";
            C.Text = "";
            D.Text = "";
            Key.Text = "";


        }
        protected void panel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminPanel.aspx");
        }

        protected void subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void question_TextChanged(object sender, EventArgs e)
        {

        }
    }
}