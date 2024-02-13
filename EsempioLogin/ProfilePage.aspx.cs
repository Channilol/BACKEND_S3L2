using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsempioLogin
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] == null)
            {
               logout.Visible = false;
               Response.Redirect("Login.aspx");
            }
            if (Request.Cookies["login"] != null)
            {
                showUsername.Text = Request.Cookies["login"]["username"];
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                HttpCookie myCookie = new HttpCookie("login");
                myCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(myCookie);
                Response.Redirect("Login.aspx");
            }
        }
    }
}