using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1.Admin.Questions
{
    public partial class QuestionEdit : System.Web.UI.Page
    {
        SqlConnection con;
         string qid;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void panel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminPanel.aspx");
        }

        protected void subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject.Items.Insert(0, new ListItem("DS", "DS"));
        }

        protected void add_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Questions/QuestionAdd.aspx");
        }

        protected void save_Click(object sender, EventArgs e)
        {
            qid = subject.Text + qno.Text;
            qno.Enabled = false;
            int r;
            string query = "update QuestionOptions set OptionA = '" + A.Text + "', OptionB = '" + B.Text + "', OptionC = '" + C.Text + "', OptionD = '" + D.Text + "' where QuestionID = '" + qid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            r=cmd.ExecuteNonQuery();

            query = "update Question set Question = '" + question.Text + "', QuestionKey = '" + Key.Text + "' where QuestionID = '" + qid + "'";
            cmd = new SqlCommand(query, con);
             r = cmd.ExecuteNonQuery();
            if (r == 1)
            {
                Response.Write("<script>alert('Question Edited!');</script>");
              
                clearFields();
                qno.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert('Error!');</script>");
                

            }
        }
        void clearFields()
        {
            qno.Text = "";
            question.Text = "";
            A.Text = "";
            B.Text = "";
            C.Text = "";
            D.Text = "";
            Key.Text = "";

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            int a,b;
            qid = subject.Text + qno.Text;
            string query1 = "delete from Question where QuestionID='"+qid+"'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            a = cmd1.ExecuteNonQuery();
            string query2 = "delete from QuestionOptions where QuestionID='" + qid + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            b= cmd2.ExecuteNonQuery();
            if (a == 1 && b==1)
            {

                Response.Write("<script>alert('Question Deleted Successfully');</script>");

                qno.Text = "";
                question.Text = "";
                A.Text = "";
                B.Text = "";
                C.Text = "";
                D.Text = "";
                Key.Text = "";

                qno.Enabled = true;
            }
            else
            {

                Response.Write("<script>alert('Error Occured');</script>");

            }

        }
              

        protected void Search_Click(object sender, EventArgs e)
        {
            qid = subject.Text + qno.Text;
            string query = "select Question.Question,Question.QuestionKey,QuestionOptions.OptionA,QuestionOptions.OptionB,QuestionOptions.OptionC,QuestionOptions.OptionD from Question inner join QuestionOptions on Question.QuestionID= QuestionOptions.QuestionID where Question.QuestionID='"+qid+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader data = cmd.ExecuteReader())
            {
                while (data.Read())
                {
                    question.Text = data.GetString(0);
                    Key.Text = data.GetString(1);
                    A.Text = data.GetString(2);
                    B.Text = data.GetString(3);
                    C.Text = data.GetString(4);
                    D.Text = data.GetString(5);
                    qno.Enabled = false;
                    subject.Enabled = false;
                }



            }
 
        }
    }
}