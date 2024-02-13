using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsempioLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) 
        {
            if (Request.Cookies["login"] != null)
            {
                Response.Redirect("ProfilePage.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (usernameLogin.Text != "")
            {
                lblUsername.Text = "";
                HttpCookie myCookie = new HttpCookie("login");
                myCookie.Values["username"] = usernameLogin.Text;
                Response.Cookies.Add(myCookie);
                Response.Redirect("ProfilePage.aspx");
            }   
            else
            {
                lblUsername.Text = "Devi scrivere un username per continuare!";
            }
        }
    }
}