using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using online_examination.Models;
using System.Data.SqlClient;

namespace online_examination.Account
{
    public partial class Register : Page
    {
        SqlConnection con;
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
            int p = Convert.ToInt32(Phone.Text);
            string query = "insert into Register values('" + Phone.Text + DOB.Text + "','" + Name.Text + "','" + Password.Text + "','" + Email.Text + "'," + p + ",'" + Address.Text + "','" + Subject.Text + "','" + DOB.Text + "'," + 1 + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
               

            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
                
            }
            
          
        }
    }
}