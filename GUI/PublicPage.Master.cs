using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class PublicPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {             
                lblUser.Text = "TK: " + Session["username"];
            }
            else
            {
                lblUser.Text = "Tài khoản";
            }
       			
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Session.Clear();
                Response.Write("<script>alert('Đăng xuất thành công')</script>");
                Response.Redirect("/Login.aspx");
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}