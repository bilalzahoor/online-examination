using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace online_examination.Candidate.Frames
{
    public partial class _80 : System.Web.UI.Page
    {
         SqlConnection con;
         string qid;
        Button clickedButton;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
            if (Application["QuestionNo"]==null)
            {

                Application["QuestionNo"] = 1;
            }
            showQuestion(Application["QuestionNo"].ToString(), Application["Subject"].ToString());
            if(clickedButton==null)
                 clickedButton = Q1;
        }
        public  void showQuestion(string no, string sub)
        {

            if (Convert.ToInt32(no) <= 30)
            {
                qid = sub + no;
                
                string query = "select Question.Question,Question.QuestionKey,QuestionOptions.OptionA,QuestionOptions.OptionB,QuestionOptions.OptionC,QuestionOptions.OptionD from Question inner join QuestionOptions on Question.QuestionID= QuestionOptions.QuestionID where Question.QuestionID='" + qid + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                using (SqlDataReader data = cmd.ExecuteReader())
                {
                    while (data.Read())
                    {
                        Question.Text = data.GetString(0);
                        //Key.Text = data.GetString(1);
                        A.Text = data.GetString(2);
                        B.Text = data.GetString(3);
                        C.Text = data.GetString(4);
                        D.Text = data.GetString(5);
                        qno.Text = no;
                        // qno.Enabled = false;
                        // subject.Enabled = false;
                    }

                }
            }
        }

        protected void NextClick(object sender, EventArgs e)
        {
            Application["QuestionNo"] = Convert.ToInt32 (Application["QuestionNo"])+1;
            showQuestion(Application["QuestionNo"].ToString(), Application["Subject"].ToString());
            
        }

        protected void QuestionClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           // clickedButton.BackColor = System.Drawing.Color.Red;
            Application["QuestionNo"] = btn.Text;
            showQuestion(Application["QuestionNo"].ToString(), Application["Subject"].ToString());
            if (clickedButton.BackColor != System.Drawing.Color.Green) {
                clickedButton.BackColor = System.Drawing.Color.Red;

            }
            clickedButton = btn;
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = System.Drawing.Color.Green;
            }
        }
    }
    }
