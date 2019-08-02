using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_examination.Candidate.Frames
{
    public partial class _20spx : System.Web.UI.Page
    {
        string subject;
        protected void Page_Load(object sender, EventArgs e)
        {
            subject = Application["Subject"].ToString();
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Application["QuestionNo"] = btn.Text;
            //_80.showQuestion(btn.Text,subject);
                //btn.BackColor = System.Drawing.Color.Green;
            }
    }
}