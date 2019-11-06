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

        }

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			TaiKhoanDTO tk = new TaiKhoanDTO();
			tk.TenDangNhap = txtName.Text;
			tk.MatKhau = txtPass.Text;
			if (TaiKhoanBUS.KTDangNhap(tk.TenDangNhap,tk.MatKhau))
			{
				Response.Write("<script>alert('Đăng nhập thành công')</script>");
			}
			else
			{
				Response.Write("<script>alert('Đăng nhập thất bại')</script>");
			}
		}
	}
}