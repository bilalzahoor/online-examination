using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Questions/QuestionAdd.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Questions/QuestionEdit.aspx");
        }

       
        protected void Show_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Questions/Show.aspx");
        }

        protected void panel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AdminPanel.aspx");
        }
    }
}