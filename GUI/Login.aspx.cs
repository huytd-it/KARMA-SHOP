using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
namespace GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]!= null)
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Chào mừng " + Session["username"] + " đến với chúng tôi";
            }
        }

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			TaiKhoanDTO tk = new TaiKhoanDTO();
			tk.TenDangNhap = txtName.Text;
			tk.MatKhau = txtPass.Text;
			if (TaiKhoanBUS.KTDangNhap(tk.TenDangNhap,tk.MatKhau))
			{
               
                if (TaiKhoanBUS.KTAdmin(tk.TenDangNhap))
                {
                    Response.Redirect("/Admin/Dasboard.aspx");
                }
                else
                {
                    Session["username"] = tk.TenDangNhap;
                    Response.Write(tk.TenDangNhap);
                    Response.Redirect("/Login.aspx");
                }
               
                

               
			}
			else
			{
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Đăng nhập thất bại";
                pnlThongBao.CssClass = "alert alert-danger";
                
			}
		}

    
    }
}