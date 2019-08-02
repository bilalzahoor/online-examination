using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace instructions
{
    public partial class instructions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label.Visible = false;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label.Visible = false;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Response.Redirect("~/Candidate/Paper.aspx");

            }
            else
            {
                Label.Visible = true;
            }

        }
    }
}