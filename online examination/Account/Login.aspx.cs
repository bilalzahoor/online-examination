using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using online_examination.Models;
using System.Data.SqlClient;

namespace online_examination.Account
{
    public partial class Login : Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = SUHAIL\SQLEXPRESS; Initial Catalog = online examination; Integrated Security = True");
            con.Open();
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        if (isAdmin() == 0)
                        {

                            Response.Redirect("~/Admin/AdminPanel.aspx");
                            //FailureText.Text = "User type is"+ isAdmin();
                            //ErrorMessage.Visible = true;

                        }
                        else
                        {
                            getSubject();
                            Response.Redirect("~/Candidate/instructions.aspx");
                        }

                        // IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        break;
                    case SignInStatus.LockedOut:
                        Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
                                                        Request.QueryString["ReturnUrl"],
                                                        RememberMe.Checked),
                                          true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        FailureText.Text = "Invalid login attempt";
                        ErrorMessage.Visible = true;
                        break;
                }
            }
        }
        protected int isAdmin() {
            int u=-1;
            string query = "select * from Register where EmailID='" + Email.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader data = cmd.ExecuteReader())
            {
                while (data.Read())
                {
                   u =data.GetInt32(8);
                }


            }              
             return u;
        }
        protected void getSubject()
        {
           
            string query = "select Username, Subject from Register where EmailID='" + Email.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader data = cmd.ExecuteReader())
            {
                while (data.Read())
                {
                    Application["Username"] =data.GetString(0);
                    Application["Subject"]= data.GetString(1);
                }


            }
        }
    }
}