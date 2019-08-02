using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_examination.Candidate.paperframes
{
    public partial class _10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Username.Text = Application["Username"].ToString();
            Subject.Text = Application["Subject"].ToString();
        }
    }
}