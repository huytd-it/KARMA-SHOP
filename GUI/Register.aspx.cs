using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();

            tk.TenDangNhap = txtName.Text;
            tk.MatKhau = txtPass.Text;
            tk.Email = txtEmail.Text;
            string KTMatKhau = txtRePass.Text;
            if (TaiKhoanBUS.KTMatKhau(tk.MatKhau, KTMatKhau))
            {
                if (TaiKhoanBUS.DangKi(tk))
                {
                    Response.Write("<script>alert('Đăng kí thành công')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Đăng kí không thành công')</script>");
                }
            }
            else
                Response.Write("<script> alert('Mật khẩu không giống nhau vui lòng nhập lại') </script>");
                
        }
    }
}